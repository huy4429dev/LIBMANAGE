function rhtmlspecialchars(str) {
  if (typeof str == "string") {
    str = str.replace(/&gt;/gi, ">");
    str = str.replace(/&lt;/gi, "<");
    str = str.replace(/&#039;/g, "'");
    str = str.replace(/&quot;/gi, '"');
    str = str.replace(/&amp;/gi, "&"); /* must do &amp; last */
  }
  return str;
}

function formatDate(date) {
  var d = new Date(date),
    month = "" + (d.getMonth() + 1),
    day = "" + d.getDate(),
    year = d.getFullYear();

  if (month.length < 2) month = "0" + month;
  if (day.length < 2) day = "0" + day;

  return [year, month, day].join("-");
}

function formatDateVN(date) {
    var d = new Date(date),
      month = "" + (d.getMonth() + 1),
      day = "" + d.getDate(),
      year = d.getFullYear();
  
    if (month.length < 2) month = "0" + month;
    if (day.length < 2) day = "0" + day;
  
    return [day, month, year].join("-");
  }


function getMonday(d) {
    d = new Date(d);
    var day = d.getDay(),
        diff = d.getDate() - day + (day == 0 ? -6:1); 
    return new Date(d.setDate(diff));
}

const FIRST_DAY_OF_WEEK = getMonday(new Date);

Date.prototype.addDays = function(days) {
    var date = new Date(this.valueOf());
    date.setDate(date.getDate() + days);
    return date;
}
