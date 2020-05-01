using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace Prototype
{
    public abstract class IPrototype
    {
        public abstract IPrototype ShallowCopy();

        public abstract void CopyTemplate(BinaryFormatter bf, MemoryStream ms);

        public IPrototype DeepCopy()
        {
            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ms = new MemoryStream();
            CopyTemplate(bf, ms);
            ms.Position = 0;

            return (IPrototype)bf.Deserialize(ms);
        }
    }

    public class Wallet : IPrototype
    {
        public int Balance { get; set; } = 999999;
        public override void CopyTemplate(BinaryFormatter bf, MemoryStream ms)
        {
            bf.Serialize(ms, this);
        }

        public override IPrototype ShallowCopy()
        {
            return (Wallet)MemberwiseClone();
        }
    }
}
