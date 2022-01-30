using _13_WebApi.Data;
using _13_WebApi.Helper;
using _13_WebApi.Helper.ErrorHelper;
using _13_WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _13_WebApi.Controllers
{
    //[Authorize] //Controller bazında filter uygulanabilir
    public class PersonelController : ApiController
    {
        #region Default Api Methodları
        [Authorize] //Method bazında filter uygulanabilir
        // GET api/<controller>
        public ResponseModel<List<PersonelModel>> Get()
        {
            var result = PersonelData.Personels;

            if (result != null && result.Count > 0)
            {
                return new ResponseModel<List<PersonelModel>>
                {
                    IsSuccess = true,
                    Messages = new List<string> { StatusCodeConstant.IslemBasarili },
                    StatusCode = (int)StatusCodeEnum.IslemBasarili,
                    Data = result
                };
            }
            else
            {
                return new ResponseModel<List<PersonelModel>>
                {
                    IsSuccess = true,
                    Messages = new List<string> { StatusCodeConstant.DataNotFound },
                    StatusCode = (int)StatusCodeEnum.DataNotFound,
                    Data = result
                };
            }
        }

        [Authorize]
        // GET api/<controller>/5
        public ResponseModel<PersonelModel> Get(int id)
        {
            var result = PersonelData.Personels.FirstOrDefault(p => p.Id == id);

            if (result != null)
            {
                return new ResponseModel<PersonelModel>
                {
                    IsSuccess = true,
                    Messages = new List<string> { StatusCodeConstant.IslemBasarili },
                    StatusCode = (int)StatusCodeEnum.IslemBasarili,
                    Data = result
                };
            }
            else
            {
                return new ResponseModel<PersonelModel>
                {
                    IsSuccess = true,
                    Messages = new List<string> { StatusCodeConstant.DataNotFound },
                    StatusCode = (int)StatusCodeEnum.DataNotFound,
                    Data = result
                };
            }
        }

        [Authorize]
        // POST api/<controller>
        public ResponseModel<bool> Post([FromBody]PersonelModel model)
        {
            bool result = true;
            string message = string.Empty;

            try
            {
                if (ModelState.IsValid)
                {
                    //throw new Exception("Keyfe keder hata fırlattık.");

                    PersonelData.Personels.Add(model);
                }
                else
                {
                    var response = new ResponseModel<bool>
                    {
                        IsSuccess = true,
                        Messages = new List<string> { StatusCodeConstant.ValidasyonHatasi },
                        StatusCode = (int)StatusCodeEnum.ValidasyonHatasi,
                        Data = false
                    };

                    response.Messages.AddRange(ErrorMessageHelper.FormatErrorMEssage(ModelState));
                    return response;
                }
            }
            catch (Exception ex)
            {
                result = false;
                message = ex.Message;
            }

            if (result)
            {
                return new ResponseModel<bool>
                {
                    IsSuccess = true,
                    Messages = new List<string> { StatusCodeConstant.IslemBasarili },
                    StatusCode = (int)StatusCodeEnum.IslemBasarili,
                    Data = result
                };
            }
            else
            {
                return new ResponseModel<bool>
                {
                    IsSuccess = true,
                    Messages = new List<string> { StatusCodeConstant.KayitEklerkenHataOlustu + " Hata Detayı: " + message },
                    StatusCode = (int)StatusCodeEnum.KayitEklerkenHataOlustu,
                    Data = result
                };
            }
        }

        // PUT api/<controller>/5
        public ResponseModel<bool> Put(int id, [FromBody]PersonelModel model)
        {
            bool result = true;
            string message = string.Empty;

            try
            {
                if (ModelState.IsValid)
                {
                    PersonelData.Personels.RemoveAll(p => p.Id == id);
                    PersonelData.Personels.Add(model);
                }
                else
                {
                    var response = new ResponseModel<bool>
                    {
                        IsSuccess = true,
                        Messages = new List<string> { StatusCodeConstant.ValidasyonHatasi },
                        StatusCode = (int)StatusCodeEnum.ValidasyonHatasi,
                        Data = false
                    };

                    response.Messages.AddRange(ErrorMessageHelper.FormatErrorMEssage(ModelState));
                    return response;
                }
            }
            catch (Exception ex)
            {
                result = false;
                message = ex.Message;
            }

            if (result)
            {
                return new ResponseModel<bool>
                {
                    IsSuccess = true,
                    Messages = new List<string> { StatusCodeConstant.IslemBasarili },
                    StatusCode = (int)StatusCodeEnum.IslemBasarili,
                    Data = result
                };
            }
            else
            {
                return new ResponseModel<bool>
                {
                    IsSuccess = true,
                    Messages = new List<string> { StatusCodeConstant.KayitGuncellerkenHataOlustu + " Hata Detayı: " + message },
                    StatusCode = (int)StatusCodeEnum.KayitGuncellerkenHataOlustu,
                    Data = result
                };
            }
        }

        // DELETE api/<controller>/5
        public ResponseModel<bool> Delete(int id)
        {
            bool result = true;
            string message = string.Empty;

            try
            {
                PersonelData.Personels.RemoveAll(p => p.Id == id);
            }
            catch (Exception ex)
            {
                result = false;
                message = ex.Message;
            }

            if (result)
            {
                return new ResponseModel<bool>
                {
                    IsSuccess = true,
                    Messages = new List<string> { StatusCodeConstant.IslemBasarili },
                    StatusCode = (int)StatusCodeEnum.IslemBasarili,
                    Data = result
                };
            }
            else
            {
                return new ResponseModel<bool>
                {
                    IsSuccess = true,
                    Messages = new List<string> { StatusCodeConstant.KayitSilerkenkenHataOlustu + " Hata Detayı: " + message },
                    StatusCode = (int)StatusCodeEnum.KayitSilerkenkenHataOlustu,
                    Data = result
                };
            }
        }
        #endregion

        #region Yeni Eklenen Methodlar
        //Yukarıda Get adında bir method tanımlamıştık burada parametrenin tipini değiştirerek (string namesurname) ikinci kez yazdık.
        public ResponseModel<List<PersonelModel>> Get(string nameSurname)
        {
            var result = PersonelData.Personels.Where(p => p.NameSurname.Contains(nameSurname)).ToList();

            if (result != null && result.Count > 0)
            {
                return new ResponseModel<List<PersonelModel>>
                {
                    IsSuccess = true,
                    Messages = new List<string> { StatusCodeConstant.IslemBasarili },
                    StatusCode = (int)StatusCodeEnum.IslemBasarili,
                    Data = result
                };
            }
            else
            {
                return new ResponseModel<List<PersonelModel>>
                {
                    IsSuccess = true,
                    Messages = new List<string> { StatusCodeConstant.DataNotFound },
                    StatusCode = (int)StatusCodeEnum.DataNotFound,
                    Data = result
                };
            }
        }

        [HttpPost]
        [Route("api/personel/Login")]
        public ResponseModel<bool> Login([FromBody]PersonelModel model)
        {
            var result = PersonelData.Personels.Any(p => p.Username == model.Username && p.Password == model.Password);

            if (result)
            {
                return new ResponseModel<bool>
                {
                    IsSuccess = true,
                    Messages = new List<string> { StatusCodeConstant.IslemBasarili },
                    StatusCode = (int)StatusCodeEnum.IslemBasarili,
                    Data = result
                };
            }
            else
            {
                return new ResponseModel<bool>
                {
                    IsSuccess = true,
                    Messages = new List<string> { StatusCodeConstant.LoginBasarisiz },
                    StatusCode = (int)StatusCodeEnum.LoginBasarisiz,
                    Data = result
                };
            }
        }

        [Route("api/personel/GetByTitle/{title}")]
        public ResponseModel<List<PersonelModel>> GetByTitle(string title)
        {
            var result = PersonelData.Personels.Where(p => p.Title.Contains(title)).ToList();

            if (result != null && result.Count > 0)
            {
                return new ResponseModel<List<PersonelModel>>
                {
                    IsSuccess = true,
                    Messages = new List<string> { StatusCodeConstant.IslemBasarili },
                    StatusCode = (int)StatusCodeEnum.IslemBasarili,
                    Data = result
                };
            }
            else
            {
                return new ResponseModel<List<PersonelModel>>
                {
                    IsSuccess = true,
                    Messages = new List<string> { StatusCodeConstant.DataNotFound },
                    StatusCode = (int)StatusCodeEnum.DataNotFound,
                    Data = result
                };
            }
        }
        #endregion
    }
}