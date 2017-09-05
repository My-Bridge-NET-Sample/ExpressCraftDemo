﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressCraftDemo
{
    public static class Images
    {
        public static string x32x32New = "iVBORw0KGgoAAAANSUhEUgAAACAAAAAgCAYAAABzenr0AAAAGXRFWHRTb2Z0d2FyZQBBZG9iZSBJbWFnZVJlYWR5ccllPAAAAD10RVh0VGl0bGUATmV3O1BhZ2U7QmFycztSaWJib247U3RhbmRhcmQ7SXRlbTtCbGFuaztEZWZhdWx0O0VtcHR5OxMEUu0AAABzSURBVHhe7c4xCoBADETRPV/OlTZH2KOlEjyEFnFtgwpZlrGZgd8Or0XEr70CCCBAVaPYNpJRe2gOUNmNMLOz9y7pCwdw94QAA8YyAg/ICDQgI44bAQdkhKoKAvDVvhpQxk0BCCCAAAIIIICARVUA+Ai4ADJ6HSY/hGadAAAAAElFTkSuQmCC";
        public static string x32x32Text = "iVBORw0KGgoAAAANSUhEUgAAACAAAAAgCAYAAABzenr0AAAAGXRFWHRTb2Z0d2FyZQBBZG9iZSBJbWFnZVJlYWR5ccllPAAAABZ0RVh0VGl0bGUAVGV4dDtQYWdlO1JlcG9ydHZhYQAAAACASURBVHhe7dexCYAwEIVh5wu4lKTNCNnDZa4SHEKL89IeKpyEp8IL/G34eEUgg6q+2ncBBOScNdhiJWs46RkgchqilLLXWpO7CwcQEYcAA+x4BB7gEWiAR2wNAQd4hAESAnDX2hsQxv0fME5zpD4ALsAFuAAX4FNMQM/4M7qKgAPfWMVvJ1VUSAAAAABJRU5ErkJggg==";
        public static string x32x32Date = "iVBORw0KGgoAAAANSUhEUgAAACAAAAAgCAYAAABzenr0AAAAGXRFWHRTb2Z0d2FyZQBBZG9iZSBJbWFnZVJlYWR5ccllPAAAAB10RVh0VGl0bGUAQ2FsZW5kYXI7U2NoZWR1bGVyO1ZpZXeFqTJSAAAAW0lEQVR4Xu3XsQkAIAwF0SzoUk7ldhGLELFRgmKKKw5EEF7xG0VVv5YbUGrTURTg7/MDXDwl63nX6ftjgBUFWAHA0/IDZOr6XToAAEYIgBGyAQCMEAAj5G8IoAOlW4QMCZMhGgAAAABJRU5ErkJggg==";
        public static string x32x32Data = "iVBORw0KGgoAAAANSUhEUgAAACAAAAAgCAYAAABzenr0AAAAGXRFWHRTb2Z0d2FyZQBBZG9iZSBJbWFnZVJlYWR5ccllPAAAADB0RVh0VGl0bGUAREI7U291cmNlO1N0b3I7ZGF0YXNvdXJjZTtEYXRhYmFzZTtBZGQ7TmV3Ivv6ywAAARlJREFUeF7t1TFqhEAYBeAptl+w2xuk2MIzLFrGvUZKSWWTIsET2OUmCzYp0orY5RKmUbAIOHm7PGFBQX5mhmHB4iv8cWYe6FOltfZqNtgC/H6/3tvDCVL4hBJ+oIU/ajkreU8KJ65VJA5whDeoQJNUxT2O0gBnaEBb0sBZEICH29VIAnQOAnSSAIODAIP3AN4fgfeX8KFqmEFi8UOUQCatYQ3vEBl8iiPuUZvUsIcvKOAFYniCAHYUcBbznoJr+oet4eggwOirhmripYbX/Z4/Lppu13meX2cTtzUUBHBTQ0EANzU0CyA322spAGcTq39DHiYjrqH7AKyhzwAgqKHgHQAFqy2YHCCESFpDrgmFAcwtHLAaYAvwD8BJeZf39YQhAAAAAElFTkSuQmCC";
        public static string x32x32Currency = "iVBORw0KGgoAAAANSUhEUgAAACAAAAAgCAYAAABzenr0AAAAGXRFWHRTb2Z0d2FyZQBBZG9iZSBJbWFnZVJlYWR5ccllPAAAAB90RVh0VGl0bGUAQ3VycmVuY3k7RG9sbGFyO0J1Y2s7RXVyb/jzRY8AAAJ6SURBVHhexdZPSFRRFMfxUwOvwYxykZtIoWVkBUKbglZKQgbqjJsxoo0bd0FuykUtgrFFC/+0jCCmhbNxKblJAlsYRaQiQm9IaZeQEjpi3b6Lo8Rwz9O5I7T4zOJxzu/9mHnvzZO1d/d8IvSigBhlbGBRj2V1RmrhnBPfQBeW4ZLoTPdhFkghD1elPFK1F9CTB8rXWiADZ/iKx8ihHwVjLhNaIMKKEVpAumKxyZhdRRRSIGcELvwT2IdPmMNTOENfSIEJI6wfguv4A3cAxZACJU9QB9IQNOCc6oBLUAopsOUJegBRt9CvHsElKA++fi4HtFdg3RM0DVHP8EbNembXMIabaAopsOQJbYGovQU97tQmnnyYfthIWC8KiFHGBhb1WBaRUcC8COdxBYJOzKl5OMS4QEgXluGS6Ey3UcC8DccgSGMKDr8x+e3tYDMBebgq5ZGCYN8H0TauYvfrP4Pjupx08nGcTCpRWUCQhfP4hSG0oAERixkj+Cdeog0R7uMVyp7ZTGUBwTBcgh9z00OnWVzxBL5HI8Tjs2d+FZHv73gEzjDKUg7O4xIENzCAekziDhaMnT7rhaTHeCHpZGnCCBM16bkGLEVvARUhhyJibOMsSyUjrBWCU2g7YIFSRQEbw7u2jLCPaIaoI+jFIpyhHFJgHc6wiRe4DFEnMHuYBZbg9jGOetyG4OLh/QT2RfjF8yCagaAu4CI0Cti34TWcxwC6kEY7BO3WbRhSIDIeRHdxFFKh1ZhfxbGqC6gsnMd3TGmZOsxgx5jNQoIKqOHQPyPdlVoLpDACV6VRpEIKWHqqeCHJQFRAAVuEHIqIsa1iPZZLfCXj47/6C/mA3BgM9soUAAAAAElFTkSuQmCC";
        public static string x32x32Columns = "iVBORw0KGgoAAAANSUhEUgAAACAAAAAgCAYAAABzenr0AAAAGXRFWHRTb2Z0d2FyZQBBZG9iZSBJbWFnZVJlYWR5ccllPAAAABJ0RVh0VGl0bGUAQ29sdW1uO0dyaWQ74YXzFAAAAEJJREFUeF7t0iEOACAMBEEe338fwfAABK0YcUlNkxWzkrTuHgKqKg87f0+/IwO+blQAAwwwwAADDDDAAAMMMNA6ARty0kXERUW1agAAAABJRU5ErkJggg";
        public static string x32x32Save = "iVBORw0KGgoAAAANSUhEUgAAACAAAAAgCAYAAABzenr0AAAAGXRFWHRTb2Z0d2FyZQBBZG9iZSBJbWFnZVJlYWR5ccllPAAAAAt0RVh0VGl0bGUAU2F2ZTv56PkJAAAAj0lEQVR4Xu3XywnEMAxFUXVmyEq1pJ0UMnWkD4PKULTIIgqMGGzl4+EF7i48zsIYTKr6aA4AwDJ/irVaeohO6a/Z5/7ft0sEEEvTAT6JANoBIMvtfNtMAAAAQNyfA+LcXhMgux4AAJNFzWfA704tAOoD+IYEAAAAAJx4EfEwV3G9AVAjAFtyIUAsftXTDIANWgtqUyFPQYIAAAAASUVORK5CYII=";
        public static string x32x32Close = "iVBORw0KGgoAAAANSUhEUgAAACAAAAAgCAYAAABzenr0AAAAGXRFWHRTb2Z0d2FyZQBBZG9iZSBJbWFnZVJlYWR5ccllPAAAAB10RVh0VGl0bGUAQ2xvc2U7RXhpdDtCYXJzO1JpYmJvbjtGA7noAAAA90lEQVR4Xu3XQcrCMBCG4X/V+yhKpbj8b+L1LGgWOYuHsOgF0jjIyCyKhneCdGEX33a+JyFM9S/nPGuegMvhP8+RnwAsgFQLuEv2kugABEknuXGAlW8V2CiClDc6e6MIBEiSznaAIUj5K3oTI72Bow2yKIKUN5KT9w30hijeRFBkoZwAFPFmcAQnBwB4E5NyjZUjAEeAkwMAQIByAAAIXl4PCB8AsRLAyznCDwjgEUY/gG+4HmxMAAAbrrAnAACcnGzMIgC+9rNnY1LAKNlNB1k5RLSez/EgWYPyCULhK8nV+wYG1Vs5Q7RWTgGW9O0fpcv/ggUwax7deyAQitY//QAAAABJRU5ErkJggg==";
    }
}