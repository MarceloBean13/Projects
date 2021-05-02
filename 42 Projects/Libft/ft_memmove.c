/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_memmove.c                                       :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: mfeijao <marvin@42.fr>                     +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2021/02/24 16:09:48 by mfeijao           #+#    #+#             */
/*   Updated: 2021/02/24 16:11:25 by mfeijao          ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include <string.h>

void	*ft_memmove(void *dest, void *src, size_t size)
{
	unsigned char	*tempdest;
	unsigned char	*tempsrc;

	tempdest = (unsigned char *)dest;
	tempsrc = (unsigned char *)src;
	if (!dest && !src)
		return (dest);
	if (src < dest)
		while (size--)
			tempdest[size] = tempsrc[size];
	else
		while (size--)
			*tempdest++ = *tempsrc++;
	return (dest);
}
