using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DaprNBlocks.Core.Helpers
{
    /// <summary>
    /// Dapr Unique Identifier.
    /// </summary>
    public class UniqueIdentifier
    {
        /// <summary>
        /// The identifier.
        /// </summary>
        private readonly Guid Id;

        /// <summary>
        /// Initializes a new instance of the <see cref="UniqueIdentifier"/> class.
        /// </summary>
        public UniqueIdentifier() 
        {
            Id = Guid.NewGuid();
        }

        /// <summary>
        /// News this instance.
        /// </summary>
        /// <returns></returns>
        public static string New()
            => new UniqueIdentifier().ToString();
        

        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
            =>  Id.ToString();
        
    }
}
