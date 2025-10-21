namespace FlatOutUC_SDK.Structs
{
    public class BOOL
    {
        public int Value;

        public static implicit operator BOOL(bool v) => new(v);
        public static implicit operator BOOL(int v) => new(v);

        public static implicit operator int(BOOL v) => v.Value;
        public static implicit operator bool(BOOL v) => v.Value != 0;
        public static implicit operator string(BOOL v) => v ? "TRUE" : "FALSE";

        public BOOL(int val)
        {
            Value = val;
        }

        public BOOL(bool val)
        {
            Value = val ? 1 : 0;
        }

        public override string ToString() => this;
    }
}
