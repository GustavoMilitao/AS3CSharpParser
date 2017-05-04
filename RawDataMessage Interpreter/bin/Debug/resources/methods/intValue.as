if (this.s < 0)
        {
            if (this.t == 1)
            {
                return this.a[0] - DV;
            }
            if (this.t == 0)
            {
                return -1;
            }
        }
        else
        {
            if (this.t == 1)
            {
                return this.a[0];
            }
            if (this.t == 0)
            {
                return 0;
            }
        }
        return (this.a[1] & (1 << 32 - DB) - 1) << DB | this.a[0];
    