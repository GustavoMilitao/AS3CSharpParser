import *.*;

import __AS3__.vec.*;

import flash.display.*;

import flash.utils.*;

class _SEHLHWHWMOW extends IVMode implements IMode
{

    function _SEHLHWHWMOW(param1, param2:IPad = null)
    {
        super(param1, param2);
        return;
    }// end function

    public function encrypt(param1:ByteArray) : void
    {
        var _loc_2:* = null;
        var _loc_3:* = 0;
        var _loc_4:* = 0;
        padding.pad(param1);
        _loc_2 = getIV4e();
        _loc_3 = 0;
        while (_loc_3 < param1.length)
        {
            
            _loc_4 = 0;
            while (_loc_4 < blockSize)
            {
                
                param1[_loc_3 + _loc_4] = param1[_loc_3 + _loc_4] ^ _loc_2[_loc_4];
                _loc_4 = _loc_4 + 1;
            }
            key.encrypt(param1, _loc_3);
            _loc_2.position = 0;
            _loc_2.writeBytes(param1, _loc_3, blockSize);
            _loc_3 = _loc_3 + blockSize;
        }
        return;
    }// end function

    public function decrypt(param1:ByteArray) : void
    {
        var _loc_2:* = null;
        var _loc_3:* = null;
        var _loc_4:* = 0;
        var _loc_5:* = 0;
        _loc_2 = getIV4d();
        _loc_3 = new ByteArray();
        _loc_4 = 0;
        while (_loc_4 < param1.length)
        {
            
            _loc_3.position = 0;
            _loc_3.writeBytes(param1, _loc_4, blockSize);
            key.decrypt(param1, _loc_4);
            _loc_5 = 0;
            while (_loc_5 < blockSize)
            {
                
                param1[_loc_4 + _loc_5] = param1[_loc_4 + _loc_5] ^ _loc_2[_loc_5];
                _loc_5 = _loc_5 + 1;
            }
            _loc_2.position = 0;
            _loc_2.writeBytes(_loc_3, 0, blockSize);
            _loc_4 = _loc_4 + blockSize;
        }
        padding.unpad(param1);
        return;
    }// end function

    public function toString() : String
    {
        return key.toString() + "-cbc";
    }// end function

}