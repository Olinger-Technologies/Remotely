using System.Runtime.Serialization;

namespace Remotely.Shared.Models.Dtos;

[DataContract]
public class CursorPositionDto(double percentX, double percentY, bool isVisible)
{
    [DataMember(Name = "PercentX")]
    public double PercentX { get; set; } = percentX;

    [DataMember(Name = "PercentY")]
    public double PercentY { get; set; } = percentY;

    [DataMember(Name = "IsVisible")]
    public bool IsVisible { get; set; } = isVisible;
}
