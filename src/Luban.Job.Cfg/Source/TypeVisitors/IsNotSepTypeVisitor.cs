using Luban.Job.Common.Types;
using Luban.Job.Common.TypeVisitors;

namespace Luban.Job.Cfg.TypeVisitors
{
    class IsNotSepTypeVisitor : AllTrueVisitor
    {
        public static IsNotSepTypeVisitor Ins { get; } = new IsNotSepTypeVisitor();


        public override bool Accept(TString type)
        {
            return false;
        }

        public override bool Accept(TBytes type)
        {
            return false;
        }

        public override bool Accept(TVector2 type)
        {
            return false;
        }

        public override bool Accept(TVector3 type)
        {
            return false;
        }

        public override bool Accept(TVector4 type)
        {
            return false;
        }

        public override bool Accept(TDateTime type)
        {
            return false;
        }

        public override bool Accept(TBean type)
        {
            return false;
        }

        public override bool Accept(TArray type)
        {
            return false;
        }

        public override bool Accept(TList type)
        {
            return false;
        }

        public override bool Accept(TSet type)
        {
            return false;
        }

        public override bool Accept(TMap type)
        {
            return false;
        }
    }
}
