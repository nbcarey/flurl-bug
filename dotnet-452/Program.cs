using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Flurl;
using Flurl.Http;

namespace dotnet_452
{
    class Program
    {
        static void Main( string[] args )
        {
            Task<Stream> request = "https://www.google.com/"
                                   .SetQueryParam( "q" , "foobar" )
                                   .GetStreamAsync()
                                   ;
            request.Wait();
            Stream stream = request.Result;
            return;
        }
    }
}
