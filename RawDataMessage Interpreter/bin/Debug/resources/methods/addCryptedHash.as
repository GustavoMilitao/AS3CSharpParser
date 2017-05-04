var _loc_5:* = null;
            var _loc_6:* = null;
            if (!this._hashKey)
            {
                _loc_5 = getDefinitionByName(_a_-_---._a_--_--(-(-(-(-1820302810 + 1) + 1 - 1))));
                _loc_6 = new ByteArray();
                var _loc_7:* = _loc_6;
                var _loc_8:* = _loc_5;
                _loc_7["writeUTF"](_loc_8["getInstance"]()["gameServerTicket"] ? (var _loc_8:* = _loc_5, _loc_8["getInstance"]()["gameServerTicket"]) : (""));
                var _loc_7:* = ;
                this._hashKey = _loc_7.this["hash"](_loc_6);
            }
            var _loc_2:* = new ByteArray();
            var _loc_7:* = _loc_2;
            var _loc_8:* = ;
            _loc_7["writeBytes"](_loc_8.this["hash"](param1));
            _loc_2["position"] = -(0 * 39 - 1 + 1) - 1 + 26 + 40;
            var _loc_3:* = new _SEIWGELDMLL();
            var _loc_4:* = new _SEGGHWLLXDH(new _SEHLHWHWMOW(new _SOLLHGLEIG(this._hashKey), _loc_3));
            var _loc_7:* = _loc_3;
            var _loc_8:* = _loc_4;
            _loc_7["setBlockSize"](_loc_8["getBlockSize"]());
            var _loc_7:* = _loc_4;
            _loc_7["encrypt"](_loc_2);
            param1["position"] = param1["length"];
            var _loc_7:* = param1;
            _loc_7["writeBytes"](_loc_2);
            return;
        