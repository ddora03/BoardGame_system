const utils = require('./utils');

module.exports = function (app, db) {
  app.get('/', function (req, res) {
    res.render('main.pug', { userId: req.session.userId });
  });

  app.get('/sign-up', function (req, res) {
    res.render('sign-up.pug');
  });

  app.get('/login', function (req, res) {
    const sess = req.session;
    if (sess.userId) {
      res.redirect('/');
    } else {
      res.render('login.pug');
    }
  });

  app.post('/login', function (req, res) {
    utils.validateUser(req, res, db);
  });

  app.get('/logout', function (req, res) {
    const sess = req.session;
    if (sess.userId) {
      sess.destroy(function (err) {
        if (err) {
          console.log(err);
        } else {
          res.redirect('/');
        }
      });
    } else {
      res.redirect('/');
    }
  });

  app.get('/sign-up-complete', function (req, res) {
    res.render('sign-up-complete.pug');
  });

  app.post('/add-user', function (req, res) {
    utils.createUser(req, res, db);
  });

  app.post('/id-duplication', function (req, res) {
    utils.checkIdDuplication(req, res, db);
  });

  app.get('/game', function (req,res){
    res.render('game.pug');
  });//게임목록 게시판 접근


  app.get('/order', function (req,res){
    res.render('order.pug');
  });

  app.get('/room', function (req,res){
    res.render('room.pug');
  });

  app.get('/user_check', function (req,res){
    res.render('user_check.pug');
  });
};
