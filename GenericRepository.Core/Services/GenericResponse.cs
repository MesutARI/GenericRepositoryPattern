using System;
using System.Collections.Generic;
using System.Text;

namespace GenericRepository.Core.Services
{
    public class GenericResponse<T> where T : class
    {
        #region variables
        public T Contents { get; set; }

        public bool Success { get; set; }

        public string Message { get; set; }
        #endregion

        #region GenericResponse
        public GenericResponse(T Extra)
        {
            this.Success = true;
            this.Contents = Extra;
        }

        public GenericResponse(string message)
        {
            this.Success = false;
            this.Message = message;
        }
        #endregion
    }
}
