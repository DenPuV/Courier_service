using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Courier_service.Services
{
    public static class Localizer
    {
        public static Dictionary<string, string> RuStatus = new Dictionary<string, string>
        {
            ["accepted"] = "Принят",
            ["waiting for delivery"] = "Ожидает доставки",
            ["delivering"] = "Доставляется",
            ["delivered"] = "Доставлен",
            ["cancelled"] = "Отменен",
            ["reversed"] = "Возвращен",
            ["return"] = "Возвращается"
        };
    }
}
