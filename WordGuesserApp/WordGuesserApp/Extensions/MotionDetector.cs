namespace WordGuesserApp.Extensions;

public class MotionDetector
{
  public event Action? OnTiltUp;

  public MotionDetector()
  {
    try
    {

      Accelerometer.ReadingChanged += (s, e) =>
      {
        if (e.Reading.Acceleration.Z > 0.9) // Test d'inclinaison
        {
          OnTiltUp?.Invoke();
        }
      };
      Accelerometer.Start(SensorSpeed.UI);
    }
    catch (Exception ex)
    {
      Console.WriteLine($"Erreur lors de l'initialisation de l'accéléromètre : {ex.Message}");
    }
  }
}
