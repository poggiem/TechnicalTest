# TechTest

## Bug fixing

The bug that I found is an arithmetic operation overflow, which happens because the calculated sum overflows the memory allocated for int, we solve it by switching to long that different from int, 32bit allocation, long uses a 64bit memory allocation.

## Refactoring 

The refactoring mostly consisted of finding a way to avoid the repetition of the code, using an abstract superclass on the domain to allow us to avoid it and respecting the OCP solid principle.

For the API a simple encapsulation of some logic was required. 

## Testing

Simple testing of a few scenarios, based on the assumption that we don't want to have a vehicle start when the number of passengers is not consistent with the vehicle itself.
Adding some testing to check if the exception behaviour is correct would be a nice improvement.
