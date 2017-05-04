if (this.s < 0)
        {
            return -1;
        }
        if (this.t <= 0 || this.t == 1 && this.a[0] <= 0)
        {
            return 0;
        }
        return 1;
    