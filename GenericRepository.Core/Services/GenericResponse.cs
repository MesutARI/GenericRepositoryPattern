using System.Net;

namespace GenericRepository.Core.Services
{
    public class GenericResponse<T> where T : class
    {
        #region variables
        public T Contents { get; set; }

        public bool Success { get; set; }

        public string Message { get; set; }

        public HttpStatusCode StatusCode { get; set; }

        #endregion

        #region GenericResponse
        public GenericResponse(T Extra)
        {
            this.Success = true;
            this.Contents = Extra;
            this.StatusCode = HttpStatusCode.OK;
        }

        public GenericResponse(string message, HttpStatusCode StatusCode)
        {
            this.Success = false;
            this.Message = message;
            this.StatusCode = StatusCode;
        }

        //public GenericResponse(string message)
        //{
        //    this.Success = false;
        //    this.Message = message;
        //}


        #endregion
    }
}
