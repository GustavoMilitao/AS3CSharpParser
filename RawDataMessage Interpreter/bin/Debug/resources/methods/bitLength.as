if (this.t <= 0)
        {
            return 0;
        }
        return DB * (this.t - 1) + this.nbits(this.a[(this.t - 1)] ^ this.s & DM);
    