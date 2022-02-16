using NebulaBase.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NebulaServices
{
    /// <summary>
    /// Implements protocol to provide a single view of the Service Oriented Architecture 
    /// layer while keeping the abstraction and virtualisation of the project overall. 
    /// Initial Behaviour that distributed protocols, such as a Gossip one, will inherit from here.
    /// </summary>
    public class CloudService : AbstractNebulaService
    {

    }
}
