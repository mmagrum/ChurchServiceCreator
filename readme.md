#Church Service Creator

This application will hit Planning Center's API and pull back a list of songs (randomly sorted) that match a theme based on SongSelect's theme list (as well as your own themes manually added into planning center) and the name of the song itself (a fall-back in case there is not a theme entered) not sung in the past X months (for variety). To get ready:
 - Edit the appConfig.json file
 - Input your _appId_ and _secret_ from your SongSelect developer portal
 - Choose how recent you'd like your last sung date to be by editing _lastSungMonths_
 - If desired, choose how many songs suggestions to return (default 15) with _resultsReturned_
 
Now you just need to build it and enjoy!