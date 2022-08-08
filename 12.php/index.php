<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title> <?="Main Menu (PHP)" ?> </title>
    <link rel="stylesheet" href="css/bootstrap.min.css">
</head>
<body>
<nav class="navbar navbar-expand-lg bg-info navbar-primary sticky-top">
  <div class="container-fluid">
    <a class="navbar-brand" href="index.php">PHP & Bootstrap V5</a>
    <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
      <span class="navbar-toggler-icon"></span>
    </button>
    <div class="collapse navbar-collapse" id="navbarNav">
      <ul class="navbar-nav">
        <li class="nav-item">
          <a class="nav-link active" aria-current="page" href="index.php">Main Menu</a>
        </li>
      </ul>
    </div>
  </div>
</nav>
    <main class="container">
        <div class="row">
            <div class="col-md-6 offset-3 text-center">
            <?php echo "<h1 class='mt-5'>Main Menu (PHP)</h1>"; ?>
            <hr>
            <div class="btn-group-vertical" role="group" aria-label="Vertical button group" style="width: 24rem">
                <a href="01-hello-world.php"        class="btn btn-lg btn-outline-info text-start"><span class="badge rounded-pill bg-info">01</span> Hello World</a>
                <a href="02-info.php"               class="btn btn-lg btn-outline-info text-start" target="_black"><span class="badge rounded-pill bg-info">02</span> Info</a>
                <a href="03-comments.php"           class="btn btn-lg btn-outline-info text-start"><span class="badge rounded-pill bg-info">03</span> Comments</a>
                <a href="04-variables.php"          class="btn btn-lg btn-outline-info text-start"><span class="badge rounded-pill bg-info">04</span> Variables</a>
                <a href="05-strings.php"            class="btn btn-lg btn-outline-info text-start"><span class="badge rounded-pill bg-info">05</span> Strings</a>
                <a href="06-oper-arithmetics.php"   class="btn btn-lg btn-outline-info text-start"><span class="badge rounded-pill bg-info">06</span> Oper Arithmetics</a>
                <a href="07-oper-assignment.php"    class="btn btn-lg btn-outline-info text-start"><span class="badge rounded-pill bg-info">07</span> Oper Assignment</a>
                <a href="08-oper-comparison.php"    class="btn btn-lg btn-outline-info text-start"><span class="badge rounded-pill bg-info">08</span> Oper Comparison</a>
                <a href="09-oper-logics.php"        class="btn btn-lg btn-outline-info text-start"><span class="badge rounded-pill bg-info">09</span> Oper Logics</a>
                <a href="10-conditional-if.php"     class="btn btn-lg btn-outline-info text-start"><span class="badge rounded-pill bg-info">10</span> Conditional If</a>
            </div>
            </div>
        </div>
    
    </main>
</body>
<script src="js/jquery-3.6.0.min.js"></script>
<script src="js/bootstrap.min.js"></script>
</html>