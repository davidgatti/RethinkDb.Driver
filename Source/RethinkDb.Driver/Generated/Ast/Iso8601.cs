








//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

#pragma warning disable 1591
// ReSharper disable CheckNamespace

using System;
using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;
using System.Collections.Generic;


namespace RethinkDb.Driver.Ast {
    public class Iso8601 : ReqlExpr {

    
    
    
        public Iso8601 (object arg) : this(new Arguments(arg), null) {
        }
        public Iso8601 (Arguments args) : this(args, null) {
        }
        public Iso8601 (Arguments args, OptArgs optargs)
             : this(TermType.ISO8601, args, optargs) {
        }

    protected Iso8601 (TermType termType, Arguments args, OptArgs optargs) : base(termType, args, optargs)
    {
    }


    



    







       
      

    
        
    public static Iso8601 FromString(string iso) {
       return new Iso8601 (new Arguments(iso), null);
    }



    
    }
}
