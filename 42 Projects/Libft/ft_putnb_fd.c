/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_putnb_fd.c                                      :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: mfeijao <marvin@42.fr>                     +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2021/02/24 15:42:36 by mfeijao           #+#    #+#             */
/*   Updated: 2021/02/24 15:43:17 by mfeijao          ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include "libft.h"
#include <unistd.h>

void	colocchar(char c, int fd)
{
	write(fd, &c, 1);
}

void	ft_putnbr_fd(int nb, int fd)
{
	long int i;

	i = nb;
	if (nb < 0)
	{
		colocchar('-', fd);
		i = -i;
	}
	if (i / 10)
		ft_putnbr_fd(i / 10, fd);
	colocchar(i % 10 + '0', fd);
}
