using System;
using System.Collections.Generic;
using System.Text;

namespace Lands.Models
{
    public class Response  //son las espuestas de los servicio
    {
        public bool IsSuccess
        {
            get;
            set;
        }

        public string Message
        {
            get;
            set;
        }

        public object Result
        {
            get;
            set;
        }
    }
}
