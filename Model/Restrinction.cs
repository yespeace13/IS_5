using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_5.Model
{
    public enum Restrictions
    {
        All, 
        Organizations,
        Locality,
        None
    }

    public enum Possibilities
    {
        OpenAndEdit, 
        Add,
        Change,
        Delete,
        AddFile,
        DelFile
    }
}
