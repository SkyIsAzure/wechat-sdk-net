//
//  MenuButton.cs
//
//  Author:
//       lurongkai <lurongkai@gmail.com>
//
//  Copyright (c) 2013 lurongkai
//
//  This program is free software; you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation; either version 2 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program; if not, write to the Free Software
//  Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA 02111-1307 USA
//
using System;
using System.Collections.Generic;

namespace WeChatSdk.Core
{
    public class MenuButtonClick : MenuButtonBase
    {
        public override string type { 
            get {
                return "click";
            } 
        }

        public string key{ get; set; }

        public IList<MenuButtonBase> sub_button{ get; set; }

        public override bool IsValid() {
            return 
                base.IsValid() &&
                (sub_button.Count == 0 || sub_button.Count >= 2 && sub_button.Count <= 5) &&
                key.Length <= 128;
        }
    }
}