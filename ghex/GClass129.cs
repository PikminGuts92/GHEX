using System;

public class GClass129
{
    public void method_0(GClass129.GEnum57 genum57_0)
    {
        switch (genum57_0)
        {
        case GClass129.GEnum57.const_0:
            this.int_0 = 16;
            this.int_1 = 1;
            this.ulong_0 = 4129UL;
            this.ulong_1 = 65535UL;
            this.ulong_2 = 0UL;
            this.int_2 = 0;
            this.int_3 = 0;
            break;
        case GClass129.GEnum57.const_1:
            this.int_0 = 16;
            this.int_1 = 1;
            this.ulong_0 = 32773UL;
            this.ulong_1 = 0UL;
            this.ulong_2 = 0UL;
            this.int_2 = 1;
            this.int_3 = 1;
            break;
        case GClass129.GEnum57.const_2:
            this.int_0 = 32;
            this.int_1 = 1;
            this.ulong_0 = 79764919UL;
            this.ulong_1 = 4294967295UL;
            this.ulong_2 = 4294967295UL;
            this.int_2 = 1;
            this.int_3 = 1;
            break;
        }
        this.ulong_3 = ((1UL << this.int_0 - 1) - 1UL << 1 | 1UL);
        this.ulong_4 = 1UL << this.int_0 - 1;
        this.method_7();
        ulong num;
        if (this.int_1 == 0)
        {
            this.ulong_6 = this.ulong_1;
            num = this.ulong_1;
            for (int i = 0; i < this.int_0; i++)
            {
                ulong num2 = num & this.ulong_4;
                num <<= 1;
                if (num2 != 0UL)
                {
                    num ^= this.ulong_0;
                }
            }
            num &= this.ulong_3;
            this.ulong_5 = num;
            return;
        }
        this.ulong_5 = this.ulong_1;
        num = this.ulong_1;
        for (int i = 0; i < this.int_0; i++)
        {
            ulong num2 = num & 1UL;
            if (num2 != 0UL)
            {
                num ^= this.ulong_0;
            }
            num >>= 1;
            if (num2 != 0UL)
            {
                num |= this.ulong_4;
            }
        }
        this.ulong_6 = num;
    }

    public ulong method_1(byte[] byte_0)
    {
        ulong num = this.ulong_5;
        if (this.int_2 != 0)
        {
            num = this.method_6(num, this.int_0);
        }
        if (this.int_2 == 0)
        {
            for (int i = 0; i < byte_0.Length; i++)
            {
                num = (num << 8 ^ this.ulong_7[(int)(checked((IntPtr)(unchecked((num >> this.int_0 - 8 & 255UL) ^ (ulong)byte_0[i]))))]);
            }
        }
        else
        {
            for (int j = 0; j < byte_0.Length; j++)
            {
                num = (num >> 8 ^ this.ulong_7[(int)(checked((IntPtr)((num & 255UL) ^ unchecked((ulong)byte_0[j]))))]);
            }
        }
        if ((this.int_3 ^ this.int_2) != 0)
        {
            num = this.method_6(num, this.int_0);
        }
        num ^= this.ulong_2;
        return num & this.ulong_3;
    }

    public ulong method_2(byte[] byte_0)
    {
        ulong num = this.ulong_6;
        if (this.int_2 != 0)
        {
            num = this.method_6(num, this.int_0);
        }
        if (this.int_2 == 0)
        {
            for (int i = 0; i < byte_0.Length; i++)
            {
                num = ((num << 8 | (ulong)byte_0[i]) ^ this.ulong_7[(int)(checked((IntPtr)(num >> unchecked(this.int_0 - 8) & 255UL)))]);
            }
        }
        else
        {
            for (int j = 0; j < byte_0.Length; j++)
            {
                num = (ulong)((long)(((int)(num >> 8) | (int)byte_0[j] << this.int_0 - 8) ^ (int)this.ulong_7[(int)(checked((IntPtr)(num & 255UL)))]));
            }
        }
        if (this.int_2 == 0)
        {
            for (int k = 0; k < this.int_0 / 8; k++)
            {
                num = (num << 8 ^ this.ulong_7[(int)(checked((IntPtr)(num >> unchecked(this.int_0 - 8) & 255UL)))]);
            }
        }
        else
        {
            for (int l = 0; l < this.int_0 / 8; l++)
            {
                num = (num >> 8 ^ this.ulong_7[(int)(checked((IntPtr)(num & 255UL)))]);
            }
        }
        if ((this.int_3 ^ this.int_2) != 0)
        {
            num = this.method_6(num, this.int_0);
        }
        num ^= this.ulong_2;
        return num & this.ulong_3;
    }

    public ulong method_3(byte[] byte_0)
    {
        ulong num = this.ulong_6;
        for (int i = 0; i < byte_0.Length; i++)
        {
            if (this.int_2 != 0)
            {
                byte_0[i] = (byte)this.method_6(byte_0[i], 8);
            }
            for (ulong num3 = 128UL; num3 != 0UL; num3 >>= 1)
            {
                ulong num4 = num & this.ulong_4;
                num <<= 1;
                if ((byte_0[i] & num3) != 0UL)
                {
                    num |= 1UL;
                }
                if (num4 != 0UL)
                {
                    num ^= this.ulong_0;
                }
            }
        }
        for (int i = 0; i < this.int_0; i++)
        {
            ulong num4 = num & this.ulong_4;
            num <<= 1;
            if (num4 != 0UL)
            {
                num ^= this.ulong_0;
            }
        }
        if (this.int_3 != 0)
        {
            num = this.method_6(num, this.int_0);
        }
        num ^= this.ulong_2;
        return num & this.ulong_3;
    }

    public ulong method_4(byte[] byte_0)
    {
        ulong num = this.ulong_5;
        for (int i = 0; i < byte_0.Length; i++)
        {
            if (this.int_2 != 0)
            {
                byte_0[i] = (byte)this.method_6(byte_0[i], 8);
            }
            for (ulong num3 = 128UL; num3 > 0UL; num3 >>= 1)
            {
                ulong num4 = num & this.ulong_4;
                num <<= 1;
                if ((byte_0[i] & num3) > 0UL)
                {
                    num4 ^= this.ulong_4;
                }
                if (num4 > 0UL)
                {
                    num ^= this.ulong_0;
                }
            }
        }
        if (this.int_3 > 0)
        {
            num = this.method_6(num, this.int_0);
        }
        num ^= this.ulong_2;
        return num & this.ulong_3;
    }

    public ushort method_5(byte[] byte_0)
    {
        uint num = 65535u;
        for (int i = 0; i < byte_0.Length; i++)
        {
            uint num2 = (uint)((uint)byte_0[i] << 8);
            for (int j = 0; j < 8; j++)
            {
                if (((num ^ num2) & 32768u) != 0u)
                {
                    num = (num << 1 ^ 4129u);
                }
                else
                {
                    num <<= 1;
                }
                num2 <<= 1;
            }
        }
        return (ushort)num;
    }

    ulong method_6(ulong ulong_8, int int_4)
    {
        ulong num = 1UL;
        ulong num2 = 0UL;
        for (ulong num3 = 1UL << int_4 - 1; num3 != 0UL; num3 >>= 1)
        {
            if ((ulong_8 & num3) != 0UL)
            {
                num2 |= num;
            }
            num <<= 1;
        }
        return num2;
    }

    void method_7()
    {
        for (int i = 0; i < 256; i++)
        {
            ulong num = (ulong)((long)i);
            if (this.int_2 != 0)
            {
                num = this.method_6(num, 8);
            }
            num <<= this.int_0 - 8;
            for (int j = 0; j < 8; j++)
            {
                ulong num2 = num & this.ulong_4;
                num <<= 1;
                if (num2 != 0UL)
                {
                    num ^= this.ulong_0;
                }
            }
            if (this.int_2 != 0)
            {
                num = this.method_6(num, this.int_0);
            }
            num &= this.ulong_3;
            this.ulong_7[i] = num;
        }
    }

    int int_0 = 16;

    ulong ulong_0 = 4129UL;

    int int_1 = 1;

    ulong ulong_1 = 65535UL;

    ulong ulong_2;

    int int_2;

    int int_3;

    ulong ulong_3;

    ulong ulong_4;

    ulong ulong_5;

    ulong ulong_6;

    ulong[] ulong_7 = new ulong[256];

    public enum GEnum57
    {
        const_0,
        const_1,
        const_2
    }
}
