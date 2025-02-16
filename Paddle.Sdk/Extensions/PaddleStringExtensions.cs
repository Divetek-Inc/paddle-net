namespace Paddle.Sdk.Extensions;

using System.Globalization;

public static class PaddleStringExtensions {
    /// <summary>
    /// Converts Paddle amount string (in cents) to decimal value with 2 decimal places.
    /// </summary>
    /// <param name="paddleAmount">Amount string from Paddle (in cents)</param>
    /// <returns>Decimal value with 2 decimal places or null if conversion fails</returns>
    public static decimal? ToPaddleDecimal(this string? paddleAmount) {
        if (string.IsNullOrEmpty(paddleAmount)) {
            return null;
        }

        return decimal.TryParse(paddleAmount, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal amount)
            ? amount / 100m
            : null;
    }
}