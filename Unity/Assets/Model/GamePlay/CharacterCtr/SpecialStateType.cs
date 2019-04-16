﻿using Sirenix.OdinInspector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETModel
{
    public enum SpecialStateType
    {
        InBattle,

        UnStoppable,//无法被打断的状态,比如霸体

        NotInControl,//玩家无法操作的状态

        Invincible, // 无敌

        CantDoAction, // 无法做任何行动

        Die // 死亡
        //后续什么沉默或者其他的状态,都可以在这里加. DEMO的话,这几个足够了
    }
}
