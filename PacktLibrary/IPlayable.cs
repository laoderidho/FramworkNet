namespace Packt.Shared;
using static System.Console;
public interface IPlayable
{
 void Play();
 void Pause();
 void Stop() // default interface implementation
 {
 WriteLine("Default implementation of Stop.");
 }
}