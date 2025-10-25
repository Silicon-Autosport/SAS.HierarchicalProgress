# Hierarchical Progress
Common set of structures for enumerating and tracking the progress of multi-step procedures in .NET applications

## Design
A step is some software operation that can be executed directly or used as part of another step. This library allows for this fundamental structure to be applied.

## Features
- **Hierarchical step structure**: Nest steps within steps to model complex workflows and reuse steps across procedures
- **IProgress pattern**: Progress reporting on the de-facto .NET `IProgress<T>` pattern
- **Flexible progress reporting**: Built-in classes for indeterminate, percentage-based, and quantity-based progress reporting
- **Extendable**: Interface based design with built-in class implementation allows for extended functionality as needed

## Future Plans
- Time-based progress estimation helpers
- Composite progress estimation helpers
- UI controls for displaying steps

## License
MIT

## Contributing
Contributions welcome! Please open an issue or submit a pull request.