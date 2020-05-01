using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Wallet wallet = new Wallet();
            Wallet copiedWallet = wallet.ShallowCopy() as Wallet;
        }
    }
}
