using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfApp1.MyPages;

namespace WpfApp1.Components
{
    internal class DefinitionPerson
    {
        public static StartGamePage gamePage;
        public static int MaxStr;
        public static int MaxDex;
        public static int MaxInt;
        public static int MaxVit;
        private static float _str;
        private static float _dex;
        private static float _int;
        private static float _vit;
        private static float _health;
        private static float _mana;
        private static float _pDam;
        private static float _arm;
        private static float _mDam;
        private static float _mDef;
        private static float _crtChan;
        private static float _crtDam;
        public static float Str 
        {
            get
            {
                return _str;
            }
            set
            {
                if (_str < 0)
                {
                    _str = 0;
                }
                else if (_str > MaxStr)
                {
                    _str = MaxStr;
                }
                else
                {
                    _str = value;
                }
            }
        }
        public static float Dex
        {
            get
            {
                return _dex;
            }
            set
            {
                if (_dex < 0)
                {
                    _dex = 0;
                }
                else if (Dex > MaxDex)
                {
                    _dex = MaxDex;
                }
                else
                {
                    _dex = value;
                }
            }
        }

        public static float Int
        {
            get
            {
                return _int;
            }
            set
            {
                if (_int < 0)
                {
                    _int = 0;
                }
                else if (_int > MaxInt)
                {
                    _int = MaxInt;
                }
                else
                {
                    _int = value;
                }
            }
        }
        public static float Vit
        {
            get
            {
                return _vit;
            }
            set
            {
                if (_vit < 0)
                {
                    _vit = 0;
                }
                else if (_vit > MaxVit)
                {
                    _vit = MaxVit;
                }
                else
                {
                    _vit = value;
                }
            }
        }
        public static float Health
        {
            get { return _health; }
            set
            {
                if (_health < 0)
                {
                    _health = 0;
                }
                else
                {
                    _health = value;
                }
            }
        }
        public static float Mana
        {
            get { return _mana; }
            set
            {
                if (_mana < 0)
                {
                    _mana = 0;
                }
                else
                {
                    _mana = value;
                }
            }
        }
        public static float PDam
        {
            get { return _pDam; }
            set
            {
                if (_pDam < 0)
                {
                    _pDam = 0;
                }
                else
                {
                    _pDam = value;
                }
            }
        }
        public static float Arm
        {
            get { return _arm; }
            set
            {
                if (_arm < 0)
                {
                    _arm = 0;
                }
                else
                {
                    _arm = value;
                }
            }
        }
        public static float MDam
        {
            get { return _mDam; }
            set
            {
                if (_mDam < 0)
                {
                    _mDam = 0;
                }
                else
                {
                    _mDam = value;
                }
            }
        }
        public static float MDef
        {
            get { return _mDef; }
            set
            {
                if (_mDef < 0)
                {
                    _mDef = 0;
                }
                else
                {
                    _mDef = value;
                }
            }
        }
        public static float CrtChan
        {
            get { return _crtChan; }
            set
            {
                if (_crtChan < 0)
                {
                    _crtChan = 0;
                }
                else
                {
                    _crtChan = value;
                }
            }
        }
        public static float CrtDam
        {
            get { return _crtDam; }
            set
            {
                if (_crtDam < 0)
                {
                    _crtDam = 0;
                }
                else
                {
                    _crtDam = value;
                }
            }
        }

        public static void StartInfo(string role)
        {

            if (role == "Warrior")
            {
                MaxStr = 250;
                MaxDex = 80;
                MaxInt = 50;
                MaxVit = 100;
                _str = 30;
                _dex = 15;
                _int = 10;
                _vit = 25;
                _health = Vit * 2 + Str;
                _mana = Int;
                _pDam = Str;
                Arm = Dex;
                _mDam = (float)(Int*0.2);
                _mDef = (float)(Int * 0.5);
                _crtChan = (float)(Dex * 0.2);
                _crtDam = (float)(Dex * 0.1);
                gamePage.StrTb.Text = ((int)(Str)).ToString();
                gamePage.DexTb.Text = ((int)(Dex)).ToString();
                gamePage.IntTb.Text = ((int)(Int)).ToString();
                gamePage.VitTb.Text = ((int)(Vit)).ToString();
                gamePage.HealTb.Text = ((int)(Health)).ToString();
                gamePage.ManaTb.Text = ((int)(Mana)).ToString();
                gamePage.PDamTb.Text = ((int)(PDam)).ToString();
                gamePage.ArmTb.Text = ((int)(Arm)).ToString();
                gamePage.MDamTb.Text = ((int)(MDam)).ToString();
                gamePage.MDefTb.Text = ((int)(MDef)).ToString();
                gamePage.CrtChanTb.Text = ((int)(CrtChan)).ToString();
                gamePage.CrtDamTb.Text = ((int)CrtDam).ToString();
            }
            else if (role == "Rogue")
            {
                MaxStr = 65;
                MaxDex = 250;
                MaxInt = 70;
                MaxVit = 80;
                _str = 20;
                _dex = 30;
                _int = 15;
                _vit = 20;
                _health = (float)(Vit * 1.5 + Str * 0.5);
                _mana = (float)(Int * 1.2);
                _pDam = (float)(Str * 0.5 + Dex * 0.5);
                Arm = (float)(Dex * 1.5);
                _mDam = (float)(Int * 0.2);
                _mDef = (float)(Int * 0.5);
                _crtChan = (float)(Dex * 0.2);
                _crtDam = (float)(Dex * 0.1);
                gamePage.StrTb.Text = ((int)(Str)).ToString();
                gamePage.DexTb.Text = ((int)(Dex)).ToString();
                gamePage.IntTb.Text = ((int)(Int)).ToString();
                gamePage.VitTb.Text = ((int)(Vit)).ToString();
                gamePage.HealTb.Text = ((int)(Health)).ToString();
                gamePage.ManaTb.Text = ((int)(Mana)).ToString();
                gamePage.PDamTb.Text = ((int)(PDam)).ToString();
                gamePage.ArmTb.Text = ((int)(Arm)).ToString();
                gamePage.MDamTb.Text = ((int)(MDam)).ToString();
                gamePage.MDefTb.Text = ((int)(MDef)).ToString();
                gamePage.CrtChanTb.Text = ((int)(CrtChan)).ToString();
                gamePage.CrtDamTb.Text = ((int)CrtDam).ToString();
            }
            else if (role == "Wizard")
            {
                MaxStr = 45;
                MaxDex = 80;
                MaxInt = 250;
                MaxVit = 70;
                _str = 15;
                _dex = 20;
                _int = 35;
                _vit = 15;
                _health = (float)(Vit * 1.4 + Str * 0.2);
                _mana = (float)(Int * 1.5);
                _pDam = (float)(Str * 0.5);
                Arm = Dex;
                _mDam = Int;
                _mDef = Int;
                _crtChan = (float)(Dex * 0.2);
                _crtDam = (float)(Dex * 0.1);
                gamePage.StrTb.Text = ((int)(Str)).ToString();
                gamePage.DexTb.Text = ((int)(Dex)).ToString();
                gamePage.IntTb.Text = ((int)(Int)).ToString();
                gamePage.VitTb.Text = ((int)(Vit)).ToString();
                gamePage.HealTb.Text = ((int)(Health)).ToString();
                gamePage.ManaTb.Text = ((int)(Mana)).ToString();
                gamePage.PDamTb.Text = ((int)(PDam)).ToString();
                gamePage.ArmTb.Text = ((int)(Arm)).ToString();
                gamePage.MDamTb.Text = ((int)(MDam)).ToString();
                gamePage.MDefTb.Text = ((int)(MDef)).ToString();
                gamePage.CrtChanTb.Text = ((int)(CrtChan)).ToString();
                gamePage.CrtDamTb.Text = ((int)CrtDam).ToString();
            }
            else
            {
                MessageBox.Show("Error");
                Navigations.NextPage(new ChoicePersonPage());
            }
        }
    }
}
