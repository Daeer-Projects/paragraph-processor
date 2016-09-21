# paragraph-processor
A test to split a paragraph into a size.  Secondly to count each word in a paragraph.

There are two processes to this solution.

1. Take a paragraph and change the row lengths.
2. Count all occurances of the words in a paragraph.


Process 1:

A function to process a paragraph, and a length.
The length is used to set a line length.
The process then splits the paragraph into new lines with the line length set to the supplied length.

Issue:

The replacement of the new line creates an issue for a very specific problem.  If the phrase has a new line at the exact point where the length of lines is set, 
then the text gets spliced together creating a very long word.  This will then affect how the line is made up during the process.


Process 2:

Processes a paragraph, keeping a count of each of the words.
This is not the total amount of words in the paragraph, but how many times all of the words appear in the paragraph.

Issues:

The code tried to update a word in the dictionary before the dictionary had an values in it.