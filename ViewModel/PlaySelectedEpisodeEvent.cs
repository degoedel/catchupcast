﻿using Microsoft.Practices.Prism.PubSubEvents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodCatchup.ViewModel
{
  public class PlaySelectedEpisodeEvent : PubSubEvent<EpisodeVM>
  {
  }
}
