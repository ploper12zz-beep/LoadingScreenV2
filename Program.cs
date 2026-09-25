int totalstep = 29;

int i = 1;
while (i <= totalstep)
{
    Console.WriteLine($"Loading.. file {i} of {totalstep} completed.");
    if (i % 3 == 0)
    {
        Console.WriteLine("Checkpoint reached! Saving progress...\n");
    }
    i++;
}