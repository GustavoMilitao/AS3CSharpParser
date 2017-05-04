this.t = 1;
        this.s = param1 < 0 ? (-1) : (0);
        if (param1 > 0)
        {
            this.a[0] = param1;
        }
        else if (param1 < -1)
        {
            this.a[0] = param1 + DV;
        }
        else
        {
            this.t = 0;
        }
        return;
    