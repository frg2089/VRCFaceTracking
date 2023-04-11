﻿using System.ComponentModel;

namespace VRCFaceTracking_Next.Core.Contracts.Services;

public interface IAvatarInfo : INotifyPropertyChanged
{
    public string Name { get; set; }
    public string Id { get; set; }
    public int CurrentParameters { get; set; }
    public int CurrentParametersLegacy { get; set; }
    public bool HasAnyLegacy { get; }
    public string CurrentParametersText { get; }
    public string CurrentParametersLegacyText { get; }
}