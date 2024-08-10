using System.Text.Json.Serialization;

namespace _2024ProconTemporary.Com;

public abstract class AnswerData
{
    [JsonPropertyName("n")] public required int N { get; set; }

    [JsonPropertyName("ops")] public required IList<OperationData> Ops { get; set; }

    public abstract class OperationData
    {
        public enum Side
        {
            Up,
            Down,
            Left,
            Right
        }

        [JsonPropertyName("p")] public required int P { get; set; }

        [JsonPropertyName("x")] public required int X { get; set; }

        [JsonPropertyName("y")] public required int Y { get; set; }

        [JsonPropertyName("s")] public required Side S { get; set; }
    }
}