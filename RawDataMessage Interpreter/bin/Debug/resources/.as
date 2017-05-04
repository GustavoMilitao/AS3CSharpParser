var _loc_2:* = new ByteArray();
                    var _loc_3:* = _loc_2;
                    var _loc_4:* = ;
                    _loc_3["writeBytes"](_loc_4.this["hash"](param1));
                    _loc_2["position"] = -(-(-0));
                    pad = new _SEIWGELDMLL();
                    mode = new _SEGGHWLLXDH(new _SEHLHWHWMOW(new _AESKey(hashKey), pad));
                    var _loc_3:* = pad;
                    var _loc_4:* = mode;
                    _loc_3["setBlockSize"](_loc_4["getBlockSize"]());
                    var _loc_3:* = mode;
                    _loc_3["encrypt"](_loc_2);
                    param1["position"] = param1["length"];
                    var _loc_3:* = param1;
                    _loc_3["writeBytes"](_loc_2);
                    return;
                