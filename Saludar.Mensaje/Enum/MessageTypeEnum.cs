using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saludar.Mensajes.Enum
{
    public enum MessageType : int
    {        
        InicioProcessGeneradFile = 1,
        NoExitsInformation = 2,
        CountFileGenerad = 3,
        ValidationXSDSuccess = 4,
        FinishedProcess = 5
    }
}
