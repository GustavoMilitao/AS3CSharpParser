while (this.t <= param2)
        {
            
            var _loc_4:* = this;
            _loc_4.t = this.t + 1;
            var _loc_3:* = this.t + 1;
            this.a[_loc_3] = 0;
        }
        this.a[param2] = this.a[param2] + param1;
        while (_loc_3[_loc_2] >= DV)
        {
            
            this.a[param2] = this.a[param2] - DV;
            param2 = (param2 + 1);
            if (param2 >= this.t)
            {
                var _loc_4:* = this;
                _loc_4.t = this.t + 1;
                var _loc_3:* = this.t + 1;
                this.a[_loc_3] = 0;
            }
            var _loc_3:* = this.a;
            param2 = param2;
            var _loc_5:* = _loc_3[param2] + 1;
            _loc_3[param2] = _loc_5;
        }
        return;
    