using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;
using System.Runtime.InteropServices;

public class Bypass
{
    private static int _SWLLMOIEGO = 0;
    private static int _SELEDLDHWLH = 0;
    private static int _SGIDDDEHGI = 0;
    private static int _SDEELOLHIMW = 0;
    private static int _SEDGXHMHDLD = 0;
    private static int _SDEEXMXWHDX = 0;
    private static int _SELEIMMOWOI = 0;
    private static int _SHOXLXOXWE = 0;
    private static int _SEEGWHDWIGO = 0;
    private static int _SEHGDIDHOL = 0;
    private static int _SWDHHLIEGM = 0;
    private static int _SHIGHDGXEE = 0;
    private static int _SEOGIXOGODG = 0;
    private static int _SLEGEMGWDI = 0;
    private static int _SDXELIIEMLX = 0;
    private static int _SEIWHLHLXGX = 0;
    private static int _SHOWDHLLXO = 0;
    private static string gameServerTicket = "";


    private static int _SWGXXHMGDW(int param1, int param2 = 0)
    {
        int _loc3_ = 7944;
        int _loc4_ = 46258;
        if (param2 == 0)
        {
            _SWLLMOIEGO = -44389;
        }
        _SWLLMOIEGO = _SWLLMOIEGO + (_SWLLMOIEGO + 7175);
        if (param2 == 3)
        {
            return _SWLLMOIEGO;
        }
        while (true)
        {
            if (_loc3_ >= 7945)
            {
                break;
            }
            _SWLLMOIEGO = _SWLLMOIEGO + (param1 ^ -26556);
            if (_SEILDGHMEEH(param1 - 13858, param2 + 1) % 114 > _SEILDGHMEEH(_SWLLMOIEGO - 15528, param2 + 1) % -49 || _SHDGOGEGOW(param1 + 16144, param2 + 1) % -123 > _SEILDGHMEEH(param1 + -43949, param2 + 1) % -73)
            {
                break;
            }
            while (true)
            {
                if (_loc4_ >= 46259)
                {
                    break;
                }
                _SWLLMOIEGO = _SWLLMOIEGO + (_SWLLMOIEGO ^ -31738);
                if (_SWGXXHMGDW(_SWLLMOIEGO + -30924, param2 + 1) % -84 >= _SEILDGHMEEH(_loc3_ ^ -39939, param2 + 1) % 108 || _SEILDGHMEEH(_loc3_ - 16778, param2 + 1) % 7 >= _SEDIIXOHIIG(_loc3_ ^ -21159, param2 + 1) % -59)
                {
                    _SWLLMOIEGO = _SWLLMOIEGO - (param1 + 42554);
                }
                _loc4_++;
            }

            _loc3_++;
        }

        return _SWLLMOIEGO;

        return 0;
    }


    private static int _SEILDGHMEEH(int param1, int param2 = 0)
    {
        int _loc3_ = -28123;
        int _loc4_ = -49110;
        int _loc5_ = -2443;
        int _loc6_ = -45058;
        int _loc7_ = -1851;
        if (param2 == 0)
        {
            _SWLLMOIEGO = -39029;
        }
        _SWLLMOIEGO = _SWLLMOIEGO ^ param1 ^ 20173;
        if (param2 == 3)
        {
            return _SWLLMOIEGO;
        }
        while (true)
        {
            if (_loc3_ >= -28121)
            {
                break;
            }
            _SWLLMOIEGO = _SWLLMOIEGO - (_SWLLMOIEGO + 7212);
            if (_SEWIGMXHHDW(_loc3_ ^ 16887, param2 + 1) % 64 <= _SHDGOGEGOW(param1 ^ 14056, param2 + 1) % 73 && _SEOOWDWDXME(param1 + -19519, param2 + 1) % 95 >= _SHDGOGEGOW(param1 ^ -37109, param2 + 1) % 19)
            {
                while (true)
                {
                    if (_loc4_ >= -49107)
                    {
                        break;
                    }
                    _SWLLMOIEGO = _SWLLMOIEGO + (_loc4_ + 26019);
                    if (_SELDOIGGIHX(_SWLLMOIEGO ^ 17064, param2 + 1) % -95 < _SELDOIGGIHX(_loc3_ - -14335, param2 + 1) % 30)
                    {
                        _SWLLMOIEGO = _SWLLMOIEGO - (_SWLLMOIEGO + -3624);
                    }
                    else
                    {
                        while (true)
                        {
                            if (_loc5_ >= -2441)
                            {
                                break;
                            }
                            _SWLLMOIEGO = _SWLLMOIEGO - (_loc5_ + -30372);
                            if (_SELDOIGGIHX(param1 ^ -22501, param2 + 1) % 6 != _SEWIGMXHHDW(param1 ^ -13619, param2 + 1) % 87)
                            {
                                while (true)
                                {
                                    if (_loc6_ >= -45056)
                                    {
                                        break;
                                    }
                                    _SWLLMOIEGO = _SWLLMOIEGO ^ _loc5_ - -32641;
                                    if (_SWGXXHMGDW(_loc5_ + -14682, param2 + 1) % 72 > _SEILDGHMEEH(_loc5_ - 43281, param2 + 1) % -114)
                                    {
                                        _SWLLMOIEGO = _SWLLMOIEGO ^ _loc6_ ^ 8285;
                                    }
                                    else
                                    {
                                        while (true)
                                        {
                                            if (_loc7_ >= -1850)
                                            {
                                                break;
                                            }
                                            _SWLLMOIEGO = _SWLLMOIEGO ^ _loc7_ + -30928;
                                            if (_SEILDGHMEEH(_loc4_ ^ -3959, param2 + 1) % 10 == _SHDGOGEGOW(param1 - -19154, param2 + 1) % -77)
                                            {
                                                break;
                                            }
                                            if (_SWGXXHMGDW(_loc3_ ^ 45833, param2 + 1) % 81 < _SELDOIGGIHX(_loc6_ - 21569, param2 + 1) % -85 && _SEWIGMXHHDW(_loc5_ ^ -30959, param2 + 1) % 49 >= _SEOOWDWDXME(_SWLLMOIEGO ^ -48998, param2 + 1) % 54)
                                            {
                                                _SWLLMOIEGO = _SWLLMOIEGO ^ _loc3_ ^ 5384;
                                                _SWLLMOIEGO = _SWLLMOIEGO ^ param1 + 30263;
                                            }
                                            else
                                            {
                                                _SWLLMOIEGO = _SWLLMOIEGO + (_loc4_ - 44800);
                                            }
                                            _loc7_++;
                                        }

                                    }
                                    _loc6_++;
                                }

                            }
                            _loc5_++;
                        }

                    }
                    _loc4_++;
                }

            }
            _loc3_++;
        }

        return _SWLLMOIEGO;

        return 0;
    }


    private static int _SEGELHMLOID(int param1, int param2 = 0)
    {
        int _loc3_ = 48642;
        if (param2 == 0)
        {
            _SWLLMOIEGO = -12149;
        }
        _SWLLMOIEGO = _SWLLMOIEGO ^ _SWLLMOIEGO ^ -25293;
        if (param2 == 3)
        {
            return _SWLLMOIEGO;
        }
        while (true)
        {
            if (_loc3_ >= 48644)
            {
                break;
            }
            _SWLLMOIEGO = _SWLLMOIEGO ^ param1 + 17899;
            if (_SWGXXHMGDW(_loc3_ - 36067, param2 + 1) % -35 > _SEDIIXOHIIG(_loc3_ - 43547, param2 + 1) % -26)
            {
                _SWLLMOIEGO = _SWLLMOIEGO ^ _SWLLMOIEGO + 14736;
            }
            else
            {
                if (_SEIHLEOIGWD(param1 ^ -43580, param2 + 1) % 83 < _SWGXXHMGDW(param1 - -31042, param2 + 1) % -35 && _SELDOIGGIHX(param1 + 41143, param2 + 1) % 104 < _SEDIIXOHIIG(param1 ^ 29571, param2 + 1) % 34)
                {
                    if (_SEIHLEOIGWD(param1 + -28929, param2 + 1) % -1 < _SWGXXHMGDW(param1 + 42682, param2 + 1) % -125)
                    {
                        _SWLLMOIEGO = _SWLLMOIEGO + (_loc3_ + 48955);
                        if (_SHDGOGEGOW(param1 + 36110, param2 + 1) % -48 < _SEIHLEOIGWD(_loc3_ - -22214, param2 + 1) % -82)
                        {
                            _SWLLMOIEGO = _SWLLMOIEGO - (_SWLLMOIEGO - 25076);
                            _SWLLMOIEGO = _SWLLMOIEGO ^ param1 ^ 32966;
                        }
                    }
                    else
                    {
                        _SWLLMOIEGO = _SWLLMOIEGO ^ param1 + 40816;
                        _SWLLMOIEGO = _SWLLMOIEGO + (_SWLLMOIEGO + -23672);
                    }
                }
                else
                {
                    _SWLLMOIEGO = _SWLLMOIEGO + (_SWLLMOIEGO ^ 26061);
                    _SWLLMOIEGO = _SWLLMOIEGO ^ param1 - 43937;
                }
            }
            _loc3_++;
        }

        return _SWLLMOIEGO;

        return 0;
    }


    private static int _SEIHLEOIGWD(int param1, int param2 = 0)
    {
        int _loc3_ = 42158;
        if (param2 == 0)
        {
            _SWLLMOIEGO = -17367;
        }
        _SWLLMOIEGO = _SWLLMOIEGO - (param1 - 31816);
        if (param2 == 3)
        {
            return _SWLLMOIEGO;
        }
        while (true)
        {
            if (_loc3_ >= 42159)
            {
                break;
            }
            _SWLLMOIEGO = _SWLLMOIEGO + (_loc3_ ^ -28645);
            if (_SEIHLEOIGWD(param1 + 38066, param2 + 1) % 34 >= _SEDHOILLEIX(param1 - 34877, param2 + 1) % -59)
            {
                _SWLLMOIEGO = _SWLLMOIEGO ^ param1 + -32123;
            }
            _loc3_++;
        }

        return _SWLLMOIEGO;

        return 0;
    }


    private static int _SEDHOILLEIX(int param1, int param2 = 0)
    {
        int _loc3_ = -49096;
        int _loc4_ = -3006;
        if (param2 == 0)
        {
            _SWLLMOIEGO = 28036;
        }
        _SWLLMOIEGO = _SWLLMOIEGO - (param1 ^ 13378);
        if (param2 == 3)
        {
            return _SWLLMOIEGO;
        }
        while (true)
        {
            if (_loc3_ >= -49095)
            {
                break;
            }
            _SWLLMOIEGO = _SWLLMOIEGO + (_loc3_ + 14914);
            if (_SHDGOGEGOW(_loc3_ - -16485, param2 + 1) % 62 <= _SELDOIGGIHX(_SWLLMOIEGO ^ 9272, param2 + 1) % 61 || _SEWIGMXHHDW(param1 - -7905, param2 + 1) % -96 > _SHDGOGEGOW(_loc3_ - 37975, param2 + 1) % -29 && _SEGELHMLOID(param1 - 44523, param2 + 1) % 7 <= _SEILDGHMEEH(_SWLLMOIEGO + 10673, param2 + 1) % 57)
            {
                while (true)
                {
                    if (_loc4_ >= -3004)
                    {
                        break;
                    }
                    _SWLLMOIEGO = _SWLLMOIEGO + (_loc4_ - -31500);
                    if (_SEGELHMLOID(param1 ^ -26930, param2 + 1) % -66 <= _SEDIIXOHIIG(_loc4_ - -36080, param2 + 1) % -35 || _SEILDGHMEEH(_loc4_ ^ 31432, param2 + 1) % -90 <= _SEDIIXOHIIG(_SWLLMOIEGO + 31779, param2 + 1) % -14)
                    {
                        break;
                    }
                    _loc4_++;
                }

                _SWLLMOIEGO = _SWLLMOIEGO ^ param1 - 35580;
            }
            _loc3_++;
        }

        return _SWLLMOIEGO;

        return 0;
    }


    private static int _SELDOIGGIHX(int param1, int param2 = 0)
    {
        int _loc3_ = -37781;
        int _loc4_ = 14454;
        int _loc5_ = 4857;
        int _loc6_ = -10638;
        if (param2 == 0)
        {
            _SWLLMOIEGO = -13313;
        }
        _SWLLMOIEGO = _SWLLMOIEGO - (param1 + 22205);
        if (param2 == 3)
        {
            return _SWLLMOIEGO;
        }
        while (true)
        {
            if (_loc3_ >= -37778)
            {
                break;
            }
            _SWLLMOIEGO = _SWLLMOIEGO + (_SWLLMOIEGO + -27997);
            if (_SEDIIXOHIIG(_SWLLMOIEGO + -42447, param2 + 1) % -40 >= _SHDGOGEGOW(_loc3_ + 19028, param2 + 1) % -49 || _SEOOWDWDXME(param1 - 32116, param2 + 1) % 92 >= _SEGELHMLOID(_loc3_ ^ 41270, param2 + 1) % 115)
            {
                while (true)
                {
                    if (_loc4_ >= 14456)
                    {
                        break;
                    }
                    _SWLLMOIEGO = _SWLLMOIEGO + (_loc4_ - -34853);
                    if (_SEILDGHMEEH(_loc4_ ^ 39661, param2 + 1) % 101 > _SEGELHMLOID(_loc4_ + -22313, param2 + 1) % -61)
                    {
                        break;
                    }
                    _SWLLMOIEGO = _SWLLMOIEGO + (_loc3_ - 22614);
                    while (true)
                    {
                        if (_loc5_ >= 4860)
                        {
                            break;
                        }
                        _SWLLMOIEGO = _SWLLMOIEGO - (_loc5_ + -41347);
                        if (_SEIHLEOIGWD(_loc4_ - -36058, param2 + 1) % -117 == _SEILDGHMEEH(_SWLLMOIEGO + 13358, param2 + 1) % 99)
                        {
                            if (_SELDOIGGIHX(param1 + 45467, param2 + 1) % -45 != _SEIHLEOIGWD(_SWLLMOIEGO + 2783, param2 + 1) % 4)
                            {
                                while (true)
                                {
                                    if (_loc6_ >= -10637)
                                    {
                                        break;
                                    }
                                    _SWLLMOIEGO = _SWLLMOIEGO + (_loc3_ ^ -13362);
                                    if (_SEILDGHMEEH(_SWLLMOIEGO + 32155, param2 + 1) % 51 == _SEDHOILLEIX(param1 ^ 16028, param2 + 1) % -3)
                                    {
                                        break;
                                    }
                                    _loc6_++;
                                }

                            }
                        }
                        _loc5_++;
                    }

                    _loc4_++;
                }

            }
            else
            {
                _SWLLMOIEGO = _SWLLMOIEGO + (param1 - 4816);
            }
            _loc3_++;
        }

        return _SWLLMOIEGO;

        return 0;
    }


    private static int _SEWIGMXHHDW(int param1, int param2 = 0)
    {
        int _loc3_ = -49283;
        int _loc4_ = 27276;
        int _loc5_ = 20946;
        int _loc6_ = -27358;
        int _loc7_ = -17827;
        if (param2 == 0)
        {
            _SWLLMOIEGO = 45038;
        }
        _SWLLMOIEGO = _SWLLMOIEGO + (param1 - 22018);
        if (param2 == 3)
        {
            return _SWLLMOIEGO;
        }
        while (true)
        {
            if (_loc3_ >= -49280)
            {
                break;
            }
            _SWLLMOIEGO = _SWLLMOIEGO + (_loc3_ + 19577);
            if (_SWGXXHMGDW(param1 + 32639, param2 + 1) % -25 < _SEDHOILLEIX(param1 - -43400, param2 + 1) % 26)
            {
                while (true)
                {
                    if (_loc4_ >= 27277)
                    {
                        break;
                    }
                    _SWLLMOIEGO = _SWLLMOIEGO - (_SWLLMOIEGO + 45978);
                    if (_SWGXXHMGDW(param1 - -1452, param2 + 1) % 50 <= _SWGXXHMGDW(_loc3_ - -48753, param2 + 1) % -120 || _SEOOWDWDXME(_loc3_ - -1478, param2 + 1) % 23 > _SEDIIXOHIIG(param1 + -28556, param2 + 1) % 98)
                    {
                        while (true)
                        {
                            if (_loc5_ >= 20947)
                            {
                                break;
                            }
                            _SWLLMOIEGO = _SWLLMOIEGO + (_loc5_ ^ 28848);
                            if (_SEILDGHMEEH(param1 ^ 49725, param2 + 1) % -115 > _SEGELHMLOID(param1 - 2303, param2 + 1) % -87 && _SEILDGHMEEH(_loc3_ - -1456, param2 + 1) % 7 == _SEIHLEOIGWD(_loc3_ ^ -13771, param2 + 1) % 52)
                            {
                                _SWLLMOIEGO = _SWLLMOIEGO ^ _loc3_ ^ -16105;
                                while (true)
                                {
                                    if (_loc6_ >= -27356)
                                    {
                                        break;
                                    }
                                    _SWLLMOIEGO = _SWLLMOIEGO - (_loc3_ ^ 45636);
                                    if (!(_SEIHLEOIGWD(param1 ^ 18802, param2 + 1) % -94 == _SWGXXHMGDW(_loc6_ + 23137, param2 + 1) % -111 && _SEILDGHMEEH(param1 - 40902, param2 + 1) % 90 >= _SEILDGHMEEH(_loc4_ ^ 29227, param2 + 1) % 91))
                                    {
                                        if (_SEDHOILLEIX(_loc3_ - -46496, param2 + 1) % 3 <= _SEIHLEOIGWD(_loc5_ + 4919, param2 + 1) % -12)
                                        {
                                            if (_SELDOIGGIHX(_loc3_ ^ 42448, param2 + 1) % -38 <= _SEILDGHMEEH(_loc6_ - 9811, param2 + 1) % -7)
                                            {
                                                while (true)
                                                {
                                                    if (_loc7_ >= -17825)
                                                    {
                                                        break;
                                                    }
                                                    _SWLLMOIEGO = _SWLLMOIEGO + (_SWLLMOIEGO + -9619);
                                                    if (_SEIHLEOIGWD(_loc5_ + -45811, param2 + 1) % 1 <= _SHDGOGEGOW(_loc6_ + 6385, param2 + 1) % -45 || _SEDHOILLEIX(_loc5_ + -49764, param2 + 1) % -65 >= _SEDIIXOHIIG(_SWLLMOIEGO - 15408, param2 + 1) % 90)
                                                    {
                                                    }
                                                    _loc7_++;
                                                }

                                                _SWLLMOIEGO = _SWLLMOIEGO - (_loc5_ - -25924);
                                            }
                                            else
                                            {
                                                if (_SEDHOILLEIX(_loc3_ + -32517, param2 + 1) % 14 >= _SEWIGMXHHDW(param1 - -15641, param2 + 1) % -121)
                                                {
                                                    _SWLLMOIEGO = _SWLLMOIEGO + (_loc5_ ^ -33088);
                                                }
                                                else
                                                {
                                                    _SWLLMOIEGO = _SWLLMOIEGO + (_loc3_ ^ 39980);
                                                }
                                            }
                                            _SWLLMOIEGO = _SWLLMOIEGO - (_loc4_ - 32087);
                                        }
                                        else
                                        {
                                            _SWLLMOIEGO = _SWLLMOIEGO - (param1 - 11787);
                                        }
                                        _SWLLMOIEGO = _SWLLMOIEGO ^ _SWLLMOIEGO + 35766;
                                    }
                                    _loc6_++;
                                }

                                _loc5_++;
                                continue;
                            }
                            break;
                        }

                        _loc4_++;
                        continue;
                    }
                    break;
                }

                _SWLLMOIEGO = _SWLLMOIEGO ^ param1 - -49243;
            }
            _loc3_++;
        }

        return _SWLLMOIEGO;

        return 0;
    }


    private static int _SEOOWDWDXME(int param1, int param2 = 0)
    {
        int _loc3_ = -606;
        int _loc4_ = -31434;
        if (param2 == 0)
        {
            _SWLLMOIEGO = -36081;
        }
        _SWLLMOIEGO = _SWLLMOIEGO - (param1 ^ 11338);
        if (param2 == 3)
        {
            return _SWLLMOIEGO;
        }
        while (true)
        {
            if (_loc3_ >= -604)
            {
                break;
            }
            _SWLLMOIEGO = _SWLLMOIEGO + (_SWLLMOIEGO ^ 30096);
            if (_SWGXXHMGDW(param1 - -14585, param2 + 1) % -30 == _SEIHLEOIGWD(_SWLLMOIEGO + -11, param2 + 1) % 78)
            {
                while (true)
                {
                    if (_loc4_ >= -31433)
                    {
                        break;
                    }
                    _SWLLMOIEGO = _SWLLMOIEGO + (_loc4_ + -12046);
                    if (_SWGXXHMGDW(_SWLLMOIEGO + -1839, param2 + 1) % -54 >= _SEOOWDWDXME(param1 + 34346, param2 + 1) % -24)
                    {
                        _SWLLMOIEGO = _SWLLMOIEGO + (_loc3_ - 36798);
                    }
                    _loc4_++;
                }

                _SWLLMOIEGO = _SWLLMOIEGO - (_loc3_ + -41425);
            }
            _loc3_++;
        }

        return _SWLLMOIEGO;

        return 0;
    }


    private static int _SEDIIXOHIIG(int param1, int param2 = 0)
    {
        int _loc3_ = 12159;
        if (param2 == 0)
        {
            _SWLLMOIEGO = 1029;
        }
        _SWLLMOIEGO = _SWLLMOIEGO - (param1 ^ -12804);
        if (param2 == 3)
        {
            return _SWLLMOIEGO;
        }
        while (true)
        {
            if (_loc3_ >= 12160)
            {
                break;
            }
            _SWLLMOIEGO = _SWLLMOIEGO + (param1 ^ 35262);
            if (_SEWIGMXHHDW(param1 - -30125, param2 + 1) % -23 <= _SEOOWDWDXME(param1 ^ 14831, param2 + 1) % -45)
            {
                if (_SEDIIXOHIIG(param1 - 13822, param2 + 1) % -76 >= _SELDOIGGIHX(_SWLLMOIEGO - -8469, param2 + 1) % 32)
                {
                    break;
                }
                _SWLLMOIEGO = _SWLLMOIEGO + (_SWLLMOIEGO + -35368);
            }
            _loc3_++;
        }

        return _SWLLMOIEGO;

        return 0;
    }


    private static int _SHDGOGEGOW(int param1, int param2 = 0)
    {
        int _loc3_ = -24720;
        int _loc4_ = 10481;
        int _loc5_ = 31505;
        int _loc6_ = -46969;
        int _loc7_ = -8950;
        if (param2 == 0)
        {
            _SWLLMOIEGO = -26385;
        }
        _SWLLMOIEGO = _SWLLMOIEGO + (_SWLLMOIEGO ^ -48165);
        if (param2 == 3)
        {
            return _SWLLMOIEGO;
        }
        while (true)
        {
            if (_loc3_ >= -24717)
            {
                break;
            }
            _SWLLMOIEGO = _SWLLMOIEGO + (param1 ^ 22031);
            if (_SHDGOGEGOW(param1 - 36098, param2 + 1) % -38 >= _SHDGOGEGOW(_loc3_ ^ 43119, param2 + 1) % 111 || _SEOOWDWDXME(_loc3_ - 5223, param2 + 1) % -42 <= _SEILDGHMEEH(param1 + -1203, param2 + 1) % -56 && _SELDOIGGIHX(_loc3_ - -40627, param2 + 1) % -74 >= _SWGXXHMGDW(param1 + -4815, param2 + 1) % -5)
            {
                while (true)
                {
                    if (_loc4_ >= 10483)
                    {
                        break;
                    }
                    _SWLLMOIEGO = _SWLLMOIEGO ^ _SWLLMOIEGO ^ -47203;
                    if (_SELDOIGGIHX(_SWLLMOIEGO ^ -38442, param2 + 1) % -18 == _SHDGOGEGOW(_loc4_ + -37230, param2 + 1) % 97 && _SWGXXHMGDW(_loc3_ - -46757, param2 + 1) % 34 > _SEILDGHMEEH(param1 - 18510, param2 + 1) % 88 || _SEGELHMLOID(param1 - 21341, param2 + 1) % -92 < _SEIHLEOIGWD(param1 + 49772, param2 + 1) % -10)
                    {
                        if (_SHDGOGEGOW(_SWLLMOIEGO ^ 44847, param2 + 1) % -105 <= _SHDGOGEGOW(_loc3_ + 43220, param2 + 1) % -63)
                        {
                            if (_SEDIIXOHIIG(_SWLLMOIEGO ^ -19257, param2 + 1) % -124 == _SEDHOILLEIX(_loc3_ - -35280, param2 + 1) % 82)
                            {
                                _SWLLMOIEGO = _SWLLMOIEGO + (param1 ^ 41728);
                                break;
                            }
                            _SWLLMOIEGO = _SWLLMOIEGO + (param1 - 8067);
                            _SWLLMOIEGO = _SWLLMOIEGO ^ _loc3_ + 39380;
                        }
                        else
                        {
                            while (true)
                            {
                                if (_loc5_ >= 31506)
                                {
                                    break;
                                }
                                _SWLLMOIEGO = _SWLLMOIEGO + (_loc5_ - -48896);
                                if (!(_SEWIGMXHHDW(param1 + 27641, param2 + 1) % 95 > _SEDHOILLEIX(_loc5_ ^ -47044, param2 + 1) % -3 && _SEDIIXOHIIG(_loc4_ - -23923, param2 + 1) % -22 == _SWGXXHMGDW(_loc5_ + 40223, param2 + 1) % -79))
                                {
                                    _SWLLMOIEGO = _SWLLMOIEGO - (_loc5_ ^ -4799);
                                    if (_SHDGOGEGOW(_loc5_ ^ -28054, param2 + 1) % 27 >= _SHDGOGEGOW(_loc5_ - -18305, param2 + 1) % 92)
                                    {
                                        if (_SEGELHMLOID(_loc5_ - 33514, param2 + 1) % 79 < _SEDIIXOHIIG(_SWLLMOIEGO ^ -49328, param2 + 1) % -126)
                                        {
                                            while (true)
                                            {
                                                if (_loc6_ >= -46967)
                                                {
                                                    break;
                                                }
                                                _SWLLMOIEGO = _SWLLMOIEGO - (param1 + -30343);
                                                if (_SEDIIXOHIIG(_loc5_ ^ -14372, param2 + 1) % 27 >= _SEDIIXOHIIG(param1 ^ 40617, param2 + 1) % 85 && _SELDOIGGIHX(param1 ^ 41471, param2 + 1) % -67 == _SEOOWDWDXME(param1 ^ 41856, param2 + 1) % -40)
                                                {
                                                    break;
                                                }
                                                while (true)
                                                {
                                                    if (_loc7_ >= -8948)
                                                    {
                                                        break;
                                                    }
                                                    _SWLLMOIEGO = _SWLLMOIEGO + (_loc7_ - -19433);
                                                    if (_SEWIGMXHHDW(_loc6_ + 2571, param2 + 1) % 108 <= _SEDHOILLEIX(_loc5_ + -31356, param2 + 1) % 67)
                                                    {
                                                        break;
                                                    }
                                                    _SWLLMOIEGO = _SWLLMOIEGO - (_loc4_ ^ 12062);
                                                    _loc7_++;
                                                }

                                                _loc6_++;
                                            }

                                        }
                                        else
                                        {
                                            _SWLLMOIEGO = _SWLLMOIEGO ^ _loc4_ - -21478;
                                            _SWLLMOIEGO = _SWLLMOIEGO + (_loc3_ - 21345);
                                        }
                                        _SWLLMOIEGO = _SWLLMOIEGO + (_loc3_ - 31557);
                                    }
                                }
                                _loc5_++;
                            }

                            _SWLLMOIEGO = _SWLLMOIEGO - (_loc4_ ^ -26928);
                        }
                    }
                    _loc4_++;
                }

                _loc3_++;
                continue;
            }
            break;
        }

        return _SWLLMOIEGO;

        return 0;
    }




    private static byte[] DecryptAES(byte[] key, byte[] content)
    {
        byte[] iv = new byte[16];
        Buffer.BlockCopy(content, 0, iv, 0, 16);
        RijndaelManaged rijndael = new RijndaelManaged();
        rijndael.Mode = CipherMode.CBC;
        ICryptoTransform decryptor = rijndael.CreateDecryptor(key, iv);
        MemoryStream ms = new MemoryStream(content);
        CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read);
        byte[] decrypted = new byte[content.Length];

        int decryptedByteCount = cs.Read(decrypted, 0, decrypted.Length);
        ms.Close();
        cs.Close();

        return decrypted;
    }

    private static List<T> ToListOf<T>(byte[] array, Func<byte[], int, T> bitConverter)
    {
        var size = Marshal.SizeOf(typeof(T));
        return Enumerable.Range(0, array.Length / size)
                         .Select(i => bitConverter(array, i * size))
                         .ToList();
    }

    public static List<int> GetCheckIntegrityMessage()
    {
        _SELEDLDHWLH = -18433 - _SEILDGHMEEH(496);
        _SGIDDDEHGI = _SEDHOILLEIX(-217) + 100291;
        _SDEELOLHIMW = 222295 - _SELDOIGGIHX(29);
        _SEDGXHMHDLD = _SEDHOILLEIX(-899) + 15043;
        _SDEEXMXWHDX = _SEILDGHMEEH(-382) ^ 31673;
        _SELEIMMOWOI = -43384 - _SEWIGMXHHDW(257);
        _SHOXLXOXWE = _SEWIGMXHHDW(750) + 55813;
        _SEEGWHDWIGO = 112320 - _SELDOIGGIHX(810);
        _SEHGDIDHOL = -22391 - _SEWIGMXHHDW(451);
        _SWDHHLIEGM = _SEIHLEOIGWD(163) ^ -72075;
        _SHIGHDGXEE = _SEDHOILLEIX(-109) ^ -216174;
        _SEOGIXOGODG = -18338 - _SHDGOGEGOW(710);
        _SLEGEMGWDI = _SHDGOGEGOW(921) ^ -18406;
        _SDXELIIEMLX = -1810148 - _SEWIGMXHHDW(167);
        _SEIWHLHLXGX = _SEDIIXOHIIG(-579) ^ 12139231;
        _SHOWDHLLXO = -62551 - _SEDHOILLEIX(713);
        _SEHGDIDHOL = _SEHGDIDHOL ^ 44;
        _SDEELOLHIMW = _SDEELOLHIMW ^ 69;
        _SEDGXHMHDLD = _SEDGXHMHDLD ^ 74;
        _SHOXLXOXWE = _SHOXLXOXWE ^ 93;
        _SDEEXMXWHDX = _SDEEXMXWHDX ^ -121;
        _SLEGEMGWDI = _SLEGEMGWDI ^ -80;
        _SHOWDHLLXO = _SHOWDHLLXO ^ -20;
        _SEIWHLHLXGX = _SEIWHLHLXGX ^ 92;
        _SGIDDDEHGI = _SGIDDDEHGI ^ -45;
        _SWDHHLIEGM = _SWDHHLIEGM ^ 25;
        _SHIGHDGXEE = _SHIGHDGXEE ^ 36;
        _SEOGIXOGODG = _SEOGIXOGODG ^ -116;
        _SDXELIIEMLX = _SDXELIIEMLX ^ 105;
        _SELEDLDHWLH = _SELEDLDHWLH ^ 113;
        _SEEGWHDWIGO = _SEEGWHDWIGO ^ 41;
        _SELEIMMOWOI = _SELEIMMOWOI ^ 100;
        string dofusInvokerMD5 = "dpX/mqsv9g0gBTeh9XXWCg==";
        var _loc11_ = new BinaryWriter(new MemoryStream());
        _loc11_.Write((byte)(_SEWIGMXHHDW(123) + 42884 ^ _SEEGWHDWIGO));
        _loc11_.Write((byte)(_SEGELHMLOID(787) + -23148 ^ _SEDGXHMHDLD));
        _loc11_.Write((byte)(_SEGELHMLOID(300) ^ -23037 ^ _SHIGHDGXEE));
        _loc11_.Write((byte)(_SEWIGMXHHDW(63) ^ -27002 ^ _SLEGEMGWDI));
        _loc11_.Write((byte)(-22001 - _SWGXXHMGDW(-223) ^ _SEHGDIDHOL));
        _loc11_.Write((byte)(91487 - _SEIHLEOIGWD(177) ^ _SDXELIIEMLX));
        _loc11_.Write((byte)(_SEOOWDWDXME(638) + 44361 ^ _SWDHHLIEGM));
        _loc11_.Write((byte)(_SWGXXHMGDW(-88) + 84511 ^ _SHIGHDGXEE));
        _loc11_.Write((byte)(_SEWIGMXHHDW(103) ^ -43438 ^ _SHIGHDGXEE));
        _loc11_.Write((byte)(_SEDHOILLEIX(806) + 64275 ^ _SGIDDDEHGI));
        _loc11_.Write((byte)(_SEIHLEOIGWD(311) + -91483 ^ _SHIGHDGXEE));
        _loc11_.Write((byte)(_SWGXXHMGDW(-832) ^ 22077 ^ _SGIDDDEHGI));
        _loc11_.Write((byte)(_SELDOIGGIHX(640) + -112113 ^ _SHOWDHLLXO));
        _loc11_.Write((byte)(_SEGELHMLOID(434) + -23096 ^ _SWDHHLIEGM));
        _loc11_.Write((byte)(_SEGELHMLOID(-286) + -23037 ^ _SDXELIIEMLX));
        var _loc14_ = new BinaryWriter(new MemoryStream());
        _loc14_.Write(gameServerTicket);
        _loc14_.Write(System.Convert.FromBase64String(dofusInvokerMD5));
        _loc14_.Close();
        byte[] decrypted = DecryptAES(((MemoryStream)_loc11_.BaseStream).ToArray(), ((MemoryStream)_loc14_.BaseStream).ToArray());
        List<int> checkIntegrityMessage = ToListOf<int>(decrypted, BitConverter.ToInt32);
        return checkIntegrityMessage;
    }
}
