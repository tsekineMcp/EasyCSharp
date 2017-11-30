# Asynchronous Processing

Asynchronous processing is to execute multiple processing simultaneously.

For example, when a method is running, other methods are invoked. 
The caller method restart running when the invoked method finished.

In this case, each method runs in turn, in other words, runs ***synchronously***.

On the other hand, when a method is running, other methods are invoked and go ahead without waiting the end of caller method,
this way is called that each process runs ***asynchronously***.

## Asynchronous processing programming

### Mechanism of asynchronous processing

It is necessary to understand how threads and tasks work to image asynchronous processing.
`thread` means a flow of processing, and `task` means a execution unit of processing.

As usual, both of main processing and method1 are running in a single thread.

In the case of asynchronous, the main processing and method1 are running simultaneously.
Therefore, at the time of the main processing invoking method1, a new thread
where method1 runs is created in addtion to main thread.

## Usage scene of asynchronous processing

Asynchronous processings are used to shorten long execution time.

Such as follows:

- downloading process
- network response

etc...
 

