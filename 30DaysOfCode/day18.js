function Solution() {
  this.queue = [];
  this.stack = [];
  this.pushCharacter = function(char) {
    this.stack.push(char);
  };
  this.popCharacter = function() {
    return this.stack.pop();
  };
  this.enqueueCharacter = function(char) {
    this.queue.push(char);
  };
  this.dequeueCharacter = function() {
    return this.queue.splice(0,1);
  };
}