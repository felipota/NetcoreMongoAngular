<<<<<<< HEAD
﻿using MonolegalApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonolegalApi.BL
{
    public interface IEstadoOperador
    {
        OperadorFactura Operator { get; }
        bool ValidateEstado(Cliente cliente);
    }
}
=======
﻿using MonolegalApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonolegalApi.BL
{
    public interface IEstadoOperador
    {
        OperadorFactura Operator { get; }
        bool ValidateEstado(Cliente cliente);
    }
}
>>>>>>> 9bd5cb3e33341e4627f0d1eab90da82dc9784e56
