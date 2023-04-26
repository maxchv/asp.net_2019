var createError = require('http-errors');
var express = require('express');
var path = require('path');
var cookieParser = require('cookie-parser');
var logger = require('morgan');

const session = require('express-session');
const passprot = require('passport');
const LocalStrategy = require('passport-local').Strategy;

var indexRouter = require('./routes/index');
var usersRouter = require('./routes/users');
var loginRouter = require('./routes/login');

const db = require('./db/users');

var app = express();

// view engine setup
app.set('views', path.join(__dirname, 'views'));
app.set('view engine', 'pug');

app.use(logger('dev'));
app.use(express.json());
app.use(express.urlencoded({ extended: false }));
app.use(cookieParser());
app.use(express.static(path.join(__dirname, 'public')));

app.use(session({
  resave:false,
  saveUninitialized:false,
  secret: 'very secret key'
}));

passprot.use(new LocalStrategy((username, password, done) => {
    const user = db.findByName(username);
    if(user && user.password == password) {
        return done(null, user);      
    } 
    return done(null, false);// не нашли    
}));

passprot.serializeUser((user, done) => {
  done(null, user.id);
});

passprot.deserializeUser((id, done) => {
  const user = db.findById(id);
  if(user) {
    done(null, user);
  } else {
    done(Error('Not found'));
  }
});

app.use(passprot.initialize());
app.use(passprot.session());

app.use('/', indexRouter);
app.use('/users', usersRouter);
app.use('/login', loginRouter);

// catch 404 and forward to error handler
app.use(function(req, res, next) {
  next(createError(404));
});

// error handler
app.use(function(err, req, res, next) {
  // set locals, only providing error in development
  res.locals.message = err.message;
  res.locals.error = req.app.get('env') === 'development' ? err : {};

  // render the error page
  res.status(err.status || 500);
  res.render('error');
});

module.exports = app;
