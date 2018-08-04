using System;

namespace Restaurante.WebApi.Models
{
    public class ResponseMessage<T>
    {
        public int statusCode { get; set; }
        public T data { get; set; }
        public string message { get; set; }

        //public ResponseMessage(int statusCode, T data, string message)
        //{
        //    this.statusCode = statusCode;
        //    this.data = data;
        //    this.message = message;
        //}

    }

    public static class ReturnData<T> {
        public static ResponseMessage<T> ReturnResponse(T data)
        {
            var response = new ResponseMessage<T>();
            if (data != null)
            {
                response.statusCode = 200;
                response.message = "ok";
                response.data = data;
            }
            else
            {
                response.statusCode = 404;
                response.message = "not found";
                response.data = data;
            }

            return response;
        }
    }

}