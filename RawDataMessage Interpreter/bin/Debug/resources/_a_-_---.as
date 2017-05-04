package 
{
    import *.*;
    import flash.display.*;
    import flash.utils.*;

    public class _a_-_--- extends Sprite
    {
        private static var _a_--_-:Class = _a_-_-__;
        private static var _a_--_:Class = _a_-_;
        private static var _a_-__:Class = _a_---;
        private static var _a_-____:Array = new Array();
        private static var _a_----:Array = new Array();
        private static var _a_-___-:Boolean = false;
        private static var _a_--:int;

        public function _a_-_---()
        {
            var _loc_1:* = false;
            var _loc_2:* = true;
            if (!_loc_1)
            {
            }
            return;
            return;
        }// end function

        private static function _a_-_--() : void
        {
            var _loc_7:* = false;
            var _loc_8:* = true;
            var _loc_1:* = new _a_--_-() as ByteArray;
            var _loc_2:* = new _a_--_() as ByteArray;
            var _loc_3:* = new _a_-__() as ByteArray;
            if (_loc_8)
            {
                _loc_3.endian = Endian.LITTLE_ENDIAN;
                if (!_loc_7)
                {
                    _a_-- = _loc_3.readInt();
                }
            }
            var _loc_4:* = _loc_2.readByte();
            if (!_loc_8)
            {
            }
            var _loc_5:* = (-100 + 1) * 119;
            if (!_loc_7)
            {
                do
                {
                    
                    _a_-__-_(_loc_2);
                    if (_loc_8)
                    {
                        _loc_5++;
                    }
                    if (_loc_8)
                    {
                    }while (_loc_5 < _loc_4)
                }
                _loc_4 = _loc_1.readInt();
            }
            if (_loc_7)
            {
            }
            var _loc_6:* = -((-82 + 1) + 1 + 15 + 1) + 1;
            if (_loc_8)
            {
                while (_loc_6 < _loc_4)
                {
                    
                    if (_loc_7)
                    {
                        var _loc_0:* = _a_-_---;
                        
                        _loc_6++;
                    }
                    _a_--__(_loc_1, _a_----[_loc_6 % _a_----.length]);
                    if (_loc_8) goto 207;
                }
                if (_loc_8)
                {
                    if (_loc_7)
                    {
                    }
                    _a_-___- = true;
                }
            }
            return;
            return;
        }// end function

        private static function _a_--__(param1:ByteArray, param2:ByteArray) : void
        {
            var _loc_6:* = false;
            var _loc_7:* = true;
            var _loc_3:* = param1.readInt();
            var _loc_4:* = new ByteArray();
            if (_loc_7)
            {
                if (!_loc_7)
                {
                }
                param1.readBytes(_loc_4, (-((0 - 1) + 7) + 1 + 1) * 15 * 64, _loc_3);
            }
            var _loc_5:* = new _a_-_-_(param2);
            _loc_5._a_---_(_loc_4);
            if (_loc_7)
            {
                if (_loc_6)
                {
                }
                _loc_4.position = -(0 * 10 - 1 - 37) + 1;
                if (_loc_7)
                {
                    _a_-____.push(_loc_4.readUTFBytes(_loc_4.length));
                }
            }
            return;
            return;
        }// end function

        private static function _a_-__-_(param1:ByteArray) : void
        {
            var _loc_3:* = false;
            var _loc_4:* = true;
            var _loc_2:* = new ByteArray();
            if (!_loc_3)
            {
                if (!_loc_4)
                {
                }
                param1.readBytes(_loc_2, -(-83 - 1), 16);
            }
            if (!_loc_4)
            {
                
                _a_----.push(_loc_2);
                var _loc_0:* = _a_-_---;
            }
            if (!_loc_4)
            {
            }
            _loc_2.position = (-(0 + 1) * 32) * 47;
            if (!_loc_3) goto 69;
            return;
            if (_loc_3)
            {
            }
            return;
        }// end function

        public static function _a_--_--(param1:int) : String
        {
            var _loc_2:* = false;
            var _loc_3:* = true;
            if (!_loc_2)
            {
                if (!_a_-___-)
                {
                    if (_loc_3)
                    {
                        _a_-_--();
                    }
                }
            }
            if (!_loc_2)
            {
            }
            return _a_-____[param1 ^ _a_--];
            return;
        }// end function

        var _loc_1:* = true;
        var _loc_2:* = false;
        if (_loc_1)
        {
            if (!_loc_1)
            {
                var _loc_0:* = _a_-_---;
                
            }
            if (_loc_1)
            {
                
            }
            if (_loc_1) goto 40;
        }
        if (_loc_2)
        {
            if (!_loc_2) goto 112;
        }
        if (!_loc_1)
        {
        }
    }
}
