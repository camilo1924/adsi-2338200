<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title> <?="Upload Files" ?> </title>
    <link rel="stylesheet" href="css/bootstrap.min.css">
    <style>
        svg{
            width:1.8rem;
        }
    </style>
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
          <a class="nav-link" aria-current="page" href="index.php">Main Menu</a>
        </li>
        <li class="nav-item">
          <a class="nav-link active" aria-current="page" href="#">28- Upload Files</a>
        </li>
      </ul>
    </div>
  </div>
</nav>
    <main class="container">
        <div class="row">
            <div class="col-md-6 offset-3 text-center">
            <?php echo "<h1 class='mt-5'>Upload Files</h1>"; ?>
            <hr>
            <form action="" method="POST" enctype="multipart/form-data">
                    <div class="mb-3">
                        <figure class="figure">
                            <img src="https://via.placeholder.com/250" width="250" id="preview"class="figure-img img-fluid img-thumbnailrounded">
                        </figure>
                    </div>
					<div class="mb-3">
                        <button class="btn btn-dark btn-upload" type="button">
                            <svg xmlns="http://www.w3.org/2000/svg" class="h-6 w-6" fill="none" viewBox="0 0 24 24" stroke="currentColor" stroke-width="2">
                            <path stroke-linecap="round" stroke-linejoin="round" d="M4 16l4.586-4.586a2 2 0 012.828 0L16 16m-2-2l1.586-1.586a2 2 0 012.828 0L20 14m-6-6h.01M6 20h12a2 2 0 002-2V6a2 2 0 00-2-2H6a2 2 0 00-2 2v12a2 2 0 002 2z" />
                            </svg>
                             Select Photo  
                            </button>

						<input type="file" class="form-control d-none" id="photo" name="photo" accept="image/*">
					</div>
					<div class="mb-3">
						<button class="btn btn-success" type="submit"> 
                        <svg xmlns="http://www.w3.org/2000/svg" class="h-5 w-5" viewBox="0 0 20 20" fill="currentColor">
                        <path fill-rule="evenodd" d="M3 17a1 1 0 011-1h12a1 1 0 110 2H4a1 1 0 01-1-1zM6.293 6.707a1 1 0 010-1.414l3-3a1 1 0 011.414 0l3 3a1 1 0 01-1.414 1.414L11 5.414V13a1 1 0 11-2 0V5.414L7.707 6.707a1 1 0 01-1.414 0z" clip-rule="evenodd" />
                        </svg>
                            Upload Photo 
                        </button>
					</div>
				</form>
				<?php if ($_FILES): ?>
					<?php if ($_FILES['photo']['error'] > 0): ?>
						<div class="alert alert-danger">
							<strong>Error:</strong> You must select an image.
						</div>
					<?php else: ?>
						<?php move_uploaded_file($_FILES['photo']['tmp_name'], 'uploads/'.$_FILES['photo']['name']) ?>
						<div class="alert alert-success">
							<strong>
								File has been uploaded successfully!
							</strong>
							<li>
								<?php echo $_FILES['photo']['name'] ?>
							</li>
							<li>
								<?php echo $_FILES['photo']['type'] ?>
							</li>
							<li>
								<?php echo round($_FILES['photo']['size'] / 1024) ?> KB
							</li>
						</div>	
					<?php endif ?>
				<?php endif ?>
           
            </div>
        </div>
    
    </main>
</body>
<script src="js/jquery-3.6.0.min.js"></script>
<script src="js/bootstrap.min.js"></script>
<script>
        $(document).ready(function () {
            $('.btn-upload').click(function() {
                $('#photo').click();
            });
            $('#photo').change(function(event) {
                let reader = new FileReader()
                reader.onload = function(event) {
                    $('#preview').attr('src', event.target.result);
                }
                reader.readAsDataURL(this.files[0]);
            })
        });
    </script>
</html>