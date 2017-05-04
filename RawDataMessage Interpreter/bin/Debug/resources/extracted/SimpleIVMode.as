import *.*;

import __AS3__.vec.*;

import flash.display.*;

import flash.utils.*;

class _SEGGHWLLXDH extends Object implements IMode, ICipher
{
    protected var mode:IVMode;
    protected var cipher:ICipher;

    function _SEGGHWLLXDH(param1:IVMode)
    {
        this.mode = param1;
        this.cipher = param1 as ;
        return;
    }// end function

    public function getBlockSize() : uint
    {
        return this.mode.getBlockSize();
    }// end function

    public function dispose() : void
    {
        this.mode.dispose();
        this.mode = null;
        this.cipher = null;
        this.gc();
        return;
    }// end function

    public function encrypt(param1:ByteArray) : void
    {
        var _loc_2:* = null;
        this.cipher.encrypt(param1);
        _loc_2 = new ByteArray();
        _loc_2.writeBytes(this.mode.IV);
        _loc_2.writeBytes(param1);
        param1.position = 0;
        param1.writeBytes(_loc_2);
        return;
    }// end function

    public function decrypt(param1:ByteArray) : void
    {
        var _loc_2:* = null;
        _loc_2 = new ByteArray();
        _loc_2.writeBytes(param1, 0, this.getBlockSize());
        this.mode.IV = _loc_2;
        _loc_2 = new ByteArray();
        _loc_2.writeBytes(param1, this.getBlockSize());
        this.cipher.decrypt(_loc_2);
        param1.length = 0;
        param1.writeBytes(_loc_2);
        return;
    }// end function

    public function toString() : String
    {
        return "simple-" + this.cipher.toString();
    }// end function

}