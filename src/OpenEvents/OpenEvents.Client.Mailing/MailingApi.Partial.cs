﻿using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace OpenEvents.Client
{
    public partial class MailingApi
    {

        partial void UpdateJsonSerializerSettings(Newtonsoft.Json.JsonSerializerSettings settings)
        {
            settings.DateTimeZoneHandling = DateTimeZoneHandling.Utc;
        }

    }
}
