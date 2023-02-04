using Dapr.Client.Autogen.Grpc.v1;
using Google.Protobuf.WellKnownTypes;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaprNBlocks.StateStore.Caching
{
    /// <summary>
    /// Etag Caching.
    /// </summary>
    internal class EtagCache
    {
        /// <summary>
        /// The cache etag map.
        /// </summary>
        private static readonly ConcurrentDictionary<string, Guid> cacheEtagMap = new ConcurrentDictionary<string, Guid>(StringComparer.Ordinal);

        /// <summary>
        /// Gets the specified key.
        /// </summary>
        /// <param name="etag">The etag.</param>
        /// <returns>Guid.</returns>
        public static Guid? Get(string etag)
        {
            if (etag != null)
            {
                Guid item;
                if (cacheEtagMap.TryGetValue(etag, out item))
                    return item;
            }
            return null;
        }

        /// <summary>
        /// Sets the specified key.
        /// </summary>
        /// <param name="etag">The etag.</param>
        /// <param name="id">The identifier.</param>
        public static void Set(string etag, Guid id)
        {
            if (String.IsNullOrEmpty(etag) && id != null)
            {
                cacheEtagMap.AddOrUpdate(etag, id, (key,oldvalue) => id);
            }
        }

    }
}
