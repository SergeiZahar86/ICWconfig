namespace java ru.indas.thrift.icwagon

exception ICWException {                     
   1:string message,   # Message
   2:i32 error_code    # error code
}

struct result_t {          # Structure recognizer
  1:list<string> channels, # Channels name
  2:list<string> numbers,  # Recognized number fo channels
  3:list<bool> test,       # Test recognize
  4:string good            # Good number
}


service ICWService
{
    binary getFullImg(1:string channel) throws (1:ICWException ex),        # Get RGB image as jpeg
    binary getRegionImg(1:string channel, 2:i32 x0, 3:i32 y0, 4:i32 x1, 5:i32 y1) 
                                           throws (1:ICWException ex),     # Get region image as grayscale image as jpeg                         
    result_t Recognize() throws (1:ICWException ex),                       # Result recognized 
}