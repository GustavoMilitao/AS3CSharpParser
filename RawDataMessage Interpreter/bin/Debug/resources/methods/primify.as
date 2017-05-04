if (!this.testBit((param1 - 1)))
        {
            this.bitwiseTo(this.ONE.shiftLeft((param1 - 1)), this.op_or, this);
        }
        if (this.isEven())
        {
            this.dAddOffset(1, 0);
        }
        while (!this.isProbablePrime(param2))
        {
            
            this.dAddOffset(2, 0);
            while (this.bitLength() > param1)
            {
                
                this.subTo(this.ONE.shiftLeft((param1 - 1)), this);
            }
        }
        return;
    