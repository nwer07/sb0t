/*
    sb0t ares chat server
    Copyright (C) 2016  AresChat

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU Affero General Public License as
    published by the Free Software Foundation, either version 3 of the
    License, or (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU Affero General Public License for more details.

    You should have received a copy of the GNU Affero General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace iconnect
{
    /// <summary>Quarantined user</summary>
    public interface IQuarantined
    {
        /// <summary>Name</summary>
        String Name { get; }
        /// <summary>Guid</summary>
        Guid Guid { get; }
        /// <summary>External IP Address</summary>
        IPAddress ExternalIP { get; }
        /// <summary>Release this user from quarantine</summary>
        void Release();
    }
}
