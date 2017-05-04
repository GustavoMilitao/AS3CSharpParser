var _loc_9:* = 0 * 102 - 1 + 1 - 1 + 100 - 50;
                    var _loc_10:* = ((-22 + 1) + 1 + 14 - 1) * 95 + 1;
                    var _loc_11:* = -(0 + 1) + 107;
                    var _loc_12:* = null;
                    var _loc_13:* = null;
                    if (param2)
                    {
                        param1["position"] = -(-(0 + 45 - 1)) - 102;
                    }
                    param1["endian"] = Endian["LITTLE_ENDIAN"];
                    var _loc_14:* = param1;
                    var _loc_3:* = _loc_14["readUTFBytes"]((-3 - 13) * 115);
                    var _loc_14:* = param1;
                    var _loc_4:* = _loc_14["readUnsignedByte"]();
                    var _loc_14:* = param1;
                    var _loc_5:* = _loc_14["readUnsignedInt"]();
                    var _loc_14:* = param1;
                    var _loc_6:* = _loc_14["readUnsignedByte"]() >> (3 - 104) * 97 - 1 - 0 - 1 + 34;
                    var _loc_14:* = Math;
                    param1["position"] = _loc_14["position"] + _loc_14["ceil"](_loc_6 * (-((4 + 1) - 1) - 22 + 72 + 1) / (-(-(-(8 + 74 + 1) + 39)) + 66));
                    var _loc_14:* = param1;
                    var _loc_14:* = param1;
                    var _loc_7:* = _loc_14["readUnsignedByte"]() / (-(255 - 72 - 111 - 24) + 1 - 17) + _loc_14["readByte"]();
                    var _loc_14:* = param1;
                    var _loc_8:* = _loc_14["readUnsignedShort"]();
                    do
                    {
                        
                        var _loc_14:* = param1;
                        _loc_9 = _loc_14["readUnsignedShort"]();
                        _loc_10 = _loc_9 >> (-(((6 - 1) + 57) * 58 + 1 + 1)) * 95;
                        _loc_11 = _loc_9 & (-(1 + 1) - 1 - 1 << 6) - 1;
                        if (_loc_11 == -(63 + 98 - 111 + 33) - 1)
                        {
                            var _loc_14:* = param1;
                            _loc_11 = _loc_14["readInt"]();
                        }
                        if (_loc_10 == 77 - 91 + 113 - 102 - 9)
                        {
                            _loc_12 = new Object();
                            var _loc_14:* = param1;
                            _loc_13 = _loc_14["readUTFBytes"](_loc_11);
                            var _loc_14:* = _loc_13;
                            if (_loc_14["substr"](-(-(-0 - 46) - 59) + 54, 4) == "SMD%")
                            {
                                var _loc_14:* = ;
                                var _loc_15:* = _loc_13;
                                _loc_12["signature"] = _loc_14.this["decodeToByteArray"](_loc_15["substr"]((4 - 43) * 11 - 1 - 1));
                                _loc_12["signedData"] = new getDefinitionByName("flash.utils.ByteArray");
                                var _loc_14:* = param1;
                                _loc_14["readBytes"](_loc_12["signedData"]);
                                return _loc_12;
                            }
                        }
                        else
                        {
                            _loc_14["position"] = _loc_14["position"] + _loc_11;
                        }
                        if (_loc_10 == (-(-(0 - 1) + 44) + 1 + 1) * 35 || _loc_10 == (-(82 - 1) + 16) * 80 - 84 - 1 + 1)
                        {
                            return null;
                        }
                        }while (_loc_14["bytesAvailable"] != (-88 + 1) * 65 + 1)
                    return null;
                