# Student Score Calculator

C# console application for calculating and analyzing student scores.

## Features
- Score input validation
- Average calculation
- Grade distribution analysis
- Performance statistics
- Data persistence

## Technical Implementation
```csharp
public class ScoreCalculator
{
    private List<double> scores;
    
    public double CalculateAverage()
    {
        return scores.Any() ? scores.Average() : 0;
    }
    
    public char DetermineGrade(double score)
    {
        if (score >= 90) return 'A';
        if (score >= 80) return 'B';
        if (score >= 70) return 'C';
        if (score >= 60) return 'D';
        return 'F';
    }
}
```

## Project Structure
```
StudentScoreCalculator/
├── Program.cs           # Entry point
├── ScoreCalculator.cs   # Core logic
├── DataHandler.cs       # File operations
└── Models/
    └── Student.cs       # Student entity
```

## Usage
```bash
dotnet run
```

## Error Handling
- Input validation
- File I/O exception handling
- Null checks
- Range validation

## Future Enhancements
- GUI implementation
- Database integration
- Statistical analysis
- Export functionality

## License
MIT License
